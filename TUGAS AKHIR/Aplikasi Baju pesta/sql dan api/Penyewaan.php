<?php
// Simpanlah dengan nama file: Penyewaan.php
require_once 'database.php';

class Penyewaan
{
    private $db;
    private $table = 'penyewaan';
    public $nps = "";
    public $nama = "";
    public $jns_kostum = "";
    public $tgl_sewa = "";
    public $ukuran = "";
    public $harga = "";

    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }

    public function get_all()
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function get_by_nps(int $nps)
    {
        $query = "SELECT * FROM $this->table WHERE nps = $nps";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nps`, `nama`, `jns_kostum`, `tgl_sewa`, `ukuran`, `harga`) VALUES ('$this->nps', '$this->nama', '$this->jns_kostum', '$this->tgl_sewa', '$this->ukuran', '$this->harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nps = '$this->nps', nama = '$this->nama', jns_kostum = '$this->jns_kostum', tgl_sewa = '$this->tgl_sewa', ukuran = '$this->ukuran', harga = '$this->harga' WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function update_by_nps($nps): int
    {
        $query = "UPDATE $this->table SET nama = '$this->nama', jns_kostum = '$this->jns_kostum', tgl_sewa = '$this->tgl_sewa', ukuran = '$this->ukuran', harga = '$this->harga' WHERE nps = $nps";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_nps($nps): int
    {
        $query = "DELETE FROM $this->table WHERE nps = $nps";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}