using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eseFunzioniBasket
{
    public partial class MainForm : Form
    {
        private string nickname;
        private int record;

        public MainForm()
        {
            InitializeComponent();
            // Inizializza il record (puoi caricarlo da un file o un database se necessario)
            record = 0;
            UpdateRecordLabel();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Avvia il gioco passando il nickname
            GameForm gameForm = new GameForm(nickname);
            gameForm.ShowDialog();

            // Aggiorna il record dopo aver giocato (se necessario)
            if (gameForm.Score > record)
            {
                record = gameForm.Score;
                UpdateRecordLabel();
            }
        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {
            // Aggiorna il nickname ogni volta che il testo cambia
            nickname = txtNickname.Text;
        }

        private void UpdateRecordLabel()
        {
            lblRecord.Text = "Record: " + record.ToString();
        }
    }
}
