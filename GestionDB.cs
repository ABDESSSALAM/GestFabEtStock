using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EFM01
{
    class GestionDB
    {
        //declaration des propriter
        SqlConnection cn = new SqlConnection("data source=.;initial catalog=GestStockEtFab;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        

        //tester la connection
       public bool testCn()
        {
            try
            {
                cn.Open();
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //pour remplaire les combobox
        //---CodeArt
        public DataTable codeArt()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select CodeArticle,NomArticle from Article;";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //combobox de depot
        public DataTable codeDepot()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select CodeDepot,NomDepot from Depots";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //numero d'order
        public DataTable ComboNumOrd()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select NumOrder from OrderFabrication";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //ajouter un article
        public bool ajouterArticle(string nomArt)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Article values(@n)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("n", nomArt);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }

        //ajouter Depot
        public bool AjouterDept(string nomDep)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Depots values(@n)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("n", nomDep);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception ex){throw ex;}finally{cn.Close();}
            }
        //ajouter stock
        public bool ajouterStock(string CodeA,string CodeD,int qte)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into stocker values(@CA,@CD,@Q)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CA", CodeA);
                cmd.Parameters.AddWithValue("@CD", CodeD);
                cmd.Parameters.AddWithValue("@Q", qte);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //ajouter order
        public bool ajouterOrderFab(DateTime dt)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into OrderFabrication values(@n)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("n", dt);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //ajouter fabriquation
        public bool ajouterFab(int NumOrd,string CodeA,string CodeD,int Qte)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Fabriquer values(@NO,@CA,@CD,@Q)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NO", NumOrd);
                cmd.Parameters.AddWithValue("@CA", CodeA);
                cmd.Parameters.AddWithValue("@CD", CodeD);
                cmd.Parameters.AddWithValue("@Q", Qte);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //--------Lister
        //list Article
       public DataTable ListArticle()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select CodeArticle,NomArticle from Article";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //--D'un depot donner
        public DataTable ListArticle(string CodeD)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select A.CodeArticle,NomArticle from Article A join stocker S on S.CodeArticle=A.CodeArticle where CodeDepot=@CD";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CD", CodeD);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //List Article et depot
        public DataTable listNomArticleEtDepo()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = @"select A.NomArticle,d.NomDepot from Article A 
                join stocker S on S.CodeArticle=A.CodeArticle 
                join Depots D on D.CodeDepot=S.CodeDepot
                                    ";
                
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //list Depot
        public DataTable listDepot()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select CodeDepot,NomDepot from Depots";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }

        //list stocks
       
        public DataTable ListStock()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select * from stocker";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }

        }


        //list orderFabriquation
        public DataTable ListOrderFab()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select * from OrderFabrication";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }

        }


        //list Fabriquation
        public DataTable ListFab()
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select * from Fabriquer";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //Qte Fab sup 50
        public DataTable ListStockQteFab(int Qt)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = @"select A.NomArticle,d.NomDepot from Article A 
                join Fabriquer F on F.CodeArticle=A.CodeArticle
                join Depots D on D.CodeDepot=F.CodeDepot
                where QteFab>=@Q";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Q", Qt);

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
                dr.Close();
                return null;

            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
        //find Fabr
        public bool isExsitFab(int NumOrd, string CodeA, string CodeD)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select * from Fabriquer where NumOrder=@NO and CodeArticle=@CA and CodeDepot=@CA";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NO", NumOrd);
                cmd.Parameters.AddWithValue("@CA", CodeA);
                cmd.Parameters.AddWithValue("@CD", CodeD);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }

        }
        //mise a jour
        public bool modifierFab(int NumOrd,string CodeA,string CodeD,int Qte)
        {
            
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "update Fabriquer set QteFab=@Q  where NumOrder=@NO and CodeArticle=@CA and CodeDepot=@CD";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NO", NumOrd);
                cmd.Parameters.AddWithValue("@CA", CodeA);
                cmd.Parameters.AddWithValue("@CD", CodeD);
                cmd.Parameters.AddWithValue("@Q", Qte);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cn.Close(); }
        }
       

    }

    
    
}
