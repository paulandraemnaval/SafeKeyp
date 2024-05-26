using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CypherWithGuna.Classes;

namespace CypherWithGuna.Forms
{
    public partial class DirectoriesDisplay : UserControl
    {
        
        public DirectoriesDisplay()
        {
            InitializeComponent();
        }
        public SafeKeypMainpage parentform { get; set; }
        public void populateDirectories()
        {

            this.DirectoriesPanel.Controls.Clear();
            CollectionReference collectionReference = FireBaseHelper.db.Collection("FileRecoveryInformation");
            QuerySnapshot querySnapshot = collectionReference.GetSnapshotAsync().Result;
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                Dictionary<string, object> data = documentSnapshot.ToDictionary();
                string path = data["FilePath"].ToString();
                RecoveryItem recoveryItem = new RecoveryItem(path);
                recoveryItem.Dock = DockStyle.Top;
                this.DirectoriesPanel.Controls.Add(recoveryItem);
            }
        }


    }
}
