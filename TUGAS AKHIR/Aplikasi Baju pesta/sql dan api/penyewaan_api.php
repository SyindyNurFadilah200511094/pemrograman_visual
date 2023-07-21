<?php
require_once 'database.php';
require_once 'Penyewaan.php';
$db = new MySQLDatabase();
$penyewaan = new Penyewaan($db);
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
            $result = $penyewaan->get_by_id($id);
        } elseif ($nps > 0) {
            $result = $penyewaan->get_by_nps($nps);
        } else {
            $result = $penyewaan->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new penyewaan
        $data = json_decode(file_get_contents('php://input'), true);
        $penyewaan->nps = $data['nps'];
        $penyewaan->nama = $data['nama'];
        $penyewaan->jns_kostum = $data['jns_kostum'];
        $penyewaan->tgl_sewa = $data['tgl_sewa'];
        $penyewaan->ukuran = $data['ukuran'];
        $penyewaan->harga = $data['harga'];

        $penyewaan->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $response['status'] = 'success';
            $response['message'] = 'Data Penyewaan created successfully.';
        } else {
            $response['status'] = 'failed';
            $response['message'] = 'Data Penyewaan not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($response);
        break;

    case 'PUT':
        // Update an existing data
        $data = json_decode(file_get_contents('php://input'), true);
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nps'])) {
            $nps = $_GET['nps'];
        }
        $penyewaan->nps = $data['nps'];
        $penyewaan->nama = $data['nama'];
        $penyewaan->jns_kostum = $data['jns_kostum'];
        $penyewaan->tgl_sewa = $data['tgl_sewa'];
        $penyewaan->ukuran = $data['ukuran'];
        $penyewaan->harga = $data['harga'];
        if ($id > 0) {
            $penyewaan->update($id);
        } elseif ($nps != "") {
            $penyewaan->update_by_nps($nps);
        } else {
            // Handle the case when no id or nps is provided for update
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $response['status'] = 'success';
            $response['message'] = 'Data Penyewaan updated successfully.';
        } else {
            $response['status'] = 'failed';
            $response['message'] = 'Data Penyewaan update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($response);
        break;

    case 'DELETE':
        // Delete a data
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nps'])) {
            $nps = $_GET['nps'];
        }
        if ($id > 0) {
            $penyewaan->delete($id);
        } elseif ($nps > 0) {
            $penyewaan->delete_by_nps($nps);
        } else {
            // Handle the case when no id or nps is provided for deletion
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $response['status'] = 'success';
            $response['message'] = 'Data Penyewaan deleted successfully.';
        } else {
            $response['status'] = 'failed';
            $response['message'] = 'Data Penyewaan delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($response);
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();
