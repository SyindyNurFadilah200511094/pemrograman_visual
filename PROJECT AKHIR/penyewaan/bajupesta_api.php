<?php
require_once 'database.php';
require_once 'bajupesta.php';
$db = new MySQLDatabase();
$bajupesta = new Bajupesta($db);
$id = 0;
$nps = 0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nps'])) {
            $nps = $_GET['nps'];
        }
        if ($id > 0) {
            $result = $bajupesta->get_by_id($id);
        } elseif ($nps > 0) {
            $result = $bajupesta->get_by_nps($nps);
        } else {
            $result = $bajupesta->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new bajupesta
        $bajupesta->nps = $_POST['nps'];
        $bajupesta->nama = $_POST['nama'];
        $bajupesta->jns_kostum = $_POST['jns_kostum'];
        $bajupesta->ukuran = $_POST['ukuran'];
        $bajupesta->harga = $_PUT['harga'];
        $bajupesta->tgl_penyewaan = $_PUT['tgl_penyewaan'];

        $bajupesta->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data bajupesta created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data bajupesta not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nps'])) {
            $nps = $_GET['nps'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $bajupesta->nps = $_POST['nps'];
        $bajupesta->nama = $_POST['nama'];
        $bajupesta->jns_kostum = $_POST['jns_kostum'];
        $bajupesta->ukuran = $_POST['ukuran'];
        $bajupesta->harga = $_PUT['harga'];
        $bajupesta->tgl_penyewaan = $_PUT['tgl_penyewaan'];
        if ($id > 0) {
            $bajupesta->update($id);
        } elseif ($nps <> "") {
            $bajupesta->update_by_nps($nps);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data pasien updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data pasien update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nps'])) {
            $nps = $_GET['nps'];
        }
        if ($id > 0) {
            $bajupesta->delete($id);
        } elseif ($nps > 0) {
            $bajupesta->delete_by_nps($nps);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data pasien deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data pasien delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();
