using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using WebDisk_Client.Model;
using WebDisk_Client.Utils;

namespace WebDisk_Client.DAL
{
    class ShareDao
    {
        public ShareDescirbe Query(string code, bool isEffective = false)
        {
            try
            {
                string sql = $"select * from share where Code = '{code}'";
                sql += isEffective ? "and if (MaxVisit = 0,1,MaxVisit > Visited) and if (EndTime = '1900-01-01 00:00:00',1,StartTime < EndTime)" : "";
                ShareDescirbe share = null;
                using (MySqlDataReader reader = DBHelper.Query(sql))
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        share = new ShareDescirbe();
                        share.UserName = reader.GetString("User");
                        share.FileDescribe = new FileDescribe();
                        share.FileDescribe.Name = reader.GetString("FileName");
                        share.FileDescribe.Type = (FileType)Enum.Parse(typeof(FileType), reader.GetString("FileType"));
                        share.FileDescribe.Size = reader.GetInt64("FileSize");
                        share.AbsPath = reader.GetString("AbsPath");
                        share.StartTime = reader.GetDateTime("StartTime");
                        share.EndTime = reader.GetDateTime("EndTime");
                        share.Code = reader.GetString("Code");
                        share.MaxVisit = reader.GetInt32("MaxVisit");
                        share.Visited = reader.GetInt32("Visited");
                    }
                }
                return share;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return null;
            }
        }
        public ShareDescirbe Query(string userName, string fileName)
        {
            try
            {
                string sql = $"select * from share where User = '{userName}' and FileName = '{fileName}'";
                ShareDescirbe share = null;
                using (MySqlDataReader reader = DBHelper.Query(sql))
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        share = new ShareDescirbe();
                        share.UserName = reader.GetString("User");
                        share.FileDescribe = new FileDescribe();
                        share.FileDescribe.Name = reader.GetString("FileName");
                        share.FileDescribe.Type = (FileType)Enum.Parse(typeof(FileType), reader.GetString("FileType"));
                        share.FileDescribe.Size = reader.GetInt64("FileSize");
                        share.AbsPath = reader.GetString("AbsPath");
                        share.StartTime = reader.GetDateTime("StartTime");
                        share.EndTime = reader.GetDateTime("EndTime");
                        share.Code = reader.GetString("Code");
                        share.MaxVisit = reader.GetInt32("MaxVisit");
                        share.Visited = reader.GetInt32("Visited");
                    }
                }
                return share;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return null;
            }
        }
        public void Query(DataSet set, string tableName, User user)
        {
            try
            {
                string sql = $"select User,FileName,FileType,FileSize,AbsPath,StartTime,if(EndTime = '1900-01-01 00:00:00','永久有效',EndTime) as EndTime,Code,if(MaxVisit = 0,'无限制',MaxVisit) as MaxVisit,Visited,if(if (MaxVisit = 0,1,MaxVisit > Visited) and if (EndTime = '1900-01-01 00:00:00',1,StartTime < EndTime),'有效','无效') as Effective FROM share where User = '{user.UserName}'";
                DBHelper.QueryForDataSet(set, tableName, sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
            }
        }
        public List<string> QueryColumn(string columnName)
        {
            try
            {
                List<string> list = new List<string>();
                string sql = $"select {columnName} from share";
                using (MySqlDataReader reader = DBHelper.Query(sql))
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(columnName));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return null;
            }
        }
        public int Update(ShareDescirbe share)
        {
            try
            {
                string sql = $"update share set User = '{share.UserName}',FileName = '{share.FileDescribe.Name}',FileType = '{share.FileDescribe.Type}',FileSize = {share.FileDescribe.Size},AbsPath = '{share.AbsPath}',StartTime = '{share.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}',EndTime = '{share.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}',MaxVisit = {share.MaxVisit},Visited = {share.Visited} where Code = '{share.Code}'";
                return DBHelper.Update(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return 0;
            }
        }
        public int Insert(ShareDescirbe share)
        {
            try
            {
                string sql = $"insert into share (User,FileName,FileType,FileSize,AbsPath,EndTime,Code,MaxVisit) values('{share.UserName}','{share.FileDescribe.Name}','{share.FileDescribe.Type}',{share.FileDescribe.Size},'{share.AbsPath}','{share.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}','{share.Code}',{share.MaxVisit})";
                return DBHelper.Update(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return 0;
            }
        }
        public int Delete(string code)
        {
            try
            {
                string sql = $"delete from share where Code = '{code}'";
                return DBHelper.Update(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return 0;
            }
        }
        public bool GetFile(ShareDescirbe share, string path)
        {
            try
            {
                string cmd = $"cp -r -i -v \"{share.AbsPath}\" \"{path}\"";
                if (IsShareExists(share, path))
                {
                    return false;
                }
                else
                {
                    return SshHelper.ExcuteCommand(cmd) == "" ? false : true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return false;
            }
        }
        public bool IsShareExists(ShareDescirbe share, string path)
        {
            try
            {
                string cmd = $"find \"{path}/{share.FileDescribe.Name}\"";
                return SshHelper.ExcuteCommand(cmd).Contains("No such file or directory") ? false : true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return false;
            }
        }
    }
}
