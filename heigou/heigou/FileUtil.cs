using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heigou
{
    class FileUtil
    {

        public static void createFile(String filePath)
        {
            FileStream fileStream = null;
            try
            {
                if (!File.Exists(filePath))
                {
                    fileStream = new FileStream(filePath, FileMode.Create);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
