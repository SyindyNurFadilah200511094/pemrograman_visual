<?php
//Simpanlah dengan nama file : Mahasiswa.php
require_once 'database.php';
class Pasien
{
    private $db;
    private $table = 'bajupesta';
    public $nps = "";
    public $nama = "";
    public $jns_kostum = "";
    public $ukuran = "";
    public $harga = "";
    public $tgl_penyewaan = "";
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
        $query = "INSERT INTO $this->table (`nps`,`nama`,`jns_kostum`,`ukuran`,`harga`,`tgl_penyewaan`) VALUES ('$this->nps','$this->nama','$this->jns_kostum','$this->ukuran','$this->harga','$this->tgl_penyewaan')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nps = '$this->nps', nama = '$this->nama', jns_kostum = '$this->jns_kostum', ukuran = '$this->ukuran', harga = '$this->harga',tgl_penyewaan = '$this->tgl_penyewaan'
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_nps($nps): int
    {
        $query = "UPDATE $this->table SET nps = '$this->nps', nama = '$this->nama',jns_kostum= '$this->jns_kostum', ukuran = '$this->ukuran', harga = '$this->harga',tgl_penyewaan = '$this->tgl_penyewaan'
        WHERE nps = $nps";
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
