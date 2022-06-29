using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Twice.Model
{
    public class ProsesTwice
    {
        KonekDb db = null;
        public ProsesTwice()
        {
            db = new KonekDb();
        }
        public List<DataTwice> getTwice()
        {
            List<DataTwice> tw = new List<DataTwice>();
            using (MySqlConnection conn = db.openConnection())
            {
                string query = "SELECT * FROM twice";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            tw.Add(new DataTwice
                            {
                                id = Convert.ToInt32(sdr["id"]),
                                nama_album = sdr["nama_album"].ToString(),
                                tahun = sdr["tahun"].ToString(),
                                produser = sdr["produser"].ToString()
                            });
                        }
                    }
                    conn.Close();
                }
            }
            return tw;
        }//end get twice


        public bool saveTwice(DataTwice twice)
        {
            bool hasil = false;
            using (MySqlConnection conn = db.openConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "insert into twice (nama_album,tahun,produser)" +
                        "values(@nama_album,@tahun,@produser)";
                    cmd.Parameters.Add("nama_album", MySqlDbType.VarChar).Value = twice.nama_album;
                    cmd.Parameters.Add("tahun", MySqlDbType.VarChar).Value = twice.tahun;
                    cmd.Parameters.Add("produser", MySqlDbType.VarChar).Value = twice.produser;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    hasil = true;
                }

            }
            return hasil;
        }// end save data
        public bool UpdateTwice(DataTwice twice)
        {
            bool hasil = false;
            using (MySqlConnection conn = db.openConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "UPDATE twice SET  nama_album=@nama, tahun=@th, produser=@pd where id=@id";
                    cmd.Parameters.Add("nama", MySqlDbType.VarChar).Value = twice.nama_album;
                    cmd.Parameters.Add("th", MySqlDbType.VarChar).Value = twice.tahun;
                    cmd.Parameters.Add("pd", MySqlDbType.VarChar).Value = twice.produser;
                    cmd.Parameters.Add("id", MySqlDbType.Int32).Value = twice.id;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    hasil = true;
                }
            }
            return hasil;
        }// end updateTwice

        public bool deleteTwice(String id)
        {
            bool hasil = false;
            using (MySqlConnection conn = db.openConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "delete from twice where id=@id";
                    cmd.Parameters.Add("id", MySqlDbType.Int32).Value = Int32.Parse(id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    hasil = true;
                }
            }
            return hasil;
        }
        public DataTwice getTwiceById(string id)
        {
            DataTwice tw = new DataTwice();
            using (MySqlConnection conn = db.openConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select *from twice where id=@id";
                    cmd.Parameters.Add("id", MySqlDbType.Int32).Value = Int32.Parse(id);
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            tw = new DataTwice
                            {
                                id = Convert.ToInt32(sdr["id"]),
                                nama_album = sdr["nama_album"].ToString(),
                                tahun = sdr["tahun"].ToString(),
                                produser = sdr["produser"].ToString(),

                            };
                        }
                    }
                    conn.Close();
                }
                return tw;
            }// end gettwicebyid
        }
    }
}
