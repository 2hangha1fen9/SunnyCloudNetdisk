using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDisk_Admin.Properties;

namespace WebDisk_Admin.Utils
{
    class SshHelper
    {
        public static string ExcuteCommand(string command)
        {
            try
            {
                using (var sshClient = new SshClient($"{Settings.Default.serverIp}",$"{Settings.Default.agentAccount}", $"{Settings.Default.agentPassword}"))
                {
                    sshClient.Connect();
                    using (var cmd = sshClient.CreateCommand(command))
                    {
                        var res = cmd.Execute();
                        return cmd.Error == "" ? res : cmd.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        public static string ExcuteCommand(string command,string response)
        {
            try
            {
                using (var sshClient = new SshClient($"{Settings.Default.serverIp}",$"{Settings.Default.agentAccount}", $"{Settings.Default.agentPassword}"))
                {
                    sshClient.Connect();
                    using (var cmd = sshClient.CreateCommand(command))
                    {
                        var res = cmd.Execute(response);
                        return cmd.Error == "" ? res : cmd.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
