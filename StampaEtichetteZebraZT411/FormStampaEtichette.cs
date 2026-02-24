using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using StampaEtichetteZebraZT411.Data;
using StampaEtichetteZebraZT411.Models;
using StampaEtichetteZebraZT411.Services;

namespace StampaEtichetteZebraZT411
{
    public partial class FormStampaEtichette : Form
    {
        private readonly EtichetteRepository _repo = new EtichetteRepository();
        private readonly ConfigurazioniService _confService = new ConfigurazioniService();
        private Configurazioni _conf;
        private Etichetta _selected;
        // store original button visual state for press effect
        private System.Drawing.Color _btnOriginalBackColor;
        private System.Drawing.Point _btnOriginalLocation;
        private FlatStyle _btnOriginalFlatStyle;
        private System.Drawing.Color _btnOriginalForeColor;

        public FormStampaEtichette()
        {
            InitializeComponent();
            // attach centralized Enter/Leave handlers for TextBox and ComboBox (including nested controls)
            AttachEnterLeaveHandlers(this);
            // prepare press visual effect for print button
            //try
            //{
            //    _btnOriginalBackColor = btnStampaEtichetta.BackColor;
            //    _btnOriginalLocation = btnStampaEtichetta.Location;
            //    _btnOriginalFlatStyle = btnStampaEtichetta.FlatStyle;
            //    _btnOriginalForeColor = btnStampaEtichetta.ForeColor;
            //    // make sure button appears raised by default
            //    btnStampaEtichetta.FlatStyle = FlatStyle.Standard;
           btnStampaEtichetta.MouseDown += BtnStampaEtichetta_MouseDown;
            btnStampaEtichetta.MouseUp += BtnStampaEtichetta_MouseUp;
            btnStampaEtichetta.MouseLeave += BtnStampaEtichetta_MouseLeave;
            //}
            //catch
            //{
            //    // ignore if control not present at constructor time
            //}

            Load += FormStampaEtichette_Load;
        }

        private void AttachEnterLeaveHandlers(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Enter += Controllo_Enter;
                    c.Leave += Controllo_Leave;
                }

                if (c.HasChildren)
                    AttachEnterLeaveHandlers(c);
            }
        }

        private void Controllo_Enter(object sender, EventArgs e)
        {
            var c = sender as Control;
            if (c == null) return;
            try { c.BackColor = Color.Yellow; } catch { }
        }

        private void Controllo_Leave(object sender, EventArgs e)
        {
            var c = sender as Control;
            if (c == null) return;
            try { c.BackColor = SystemColors.Window; } catch { }
        }

        private void FormStampaEtichette_Load(object sender, EventArgs e)
        {
           
            _conf = _confService.Load();

            cmbEtichette.Items.Clear();
            cmbEtichette.Items.Add("Seleziona etichetta");
            cmbEtichette.SelectedIndex = 0;

            var all = _repo.GetAll().ToList();
            foreach (var it in all)
            {
                var text = string.IsNullOrEmpty(it.NomeVisibileInCmbEtichetta) ? it.NomeEtichetta : it.NomeVisibileInCmbEtichetta;
                cmbEtichette.Items.Add(new ComboboxItem { Text = text, Value = it.Id });
            }

            btnStampaEtichetta.Enabled = false;
            cmbEtichette.SelectedIndexChanged += CmbEtichette_SelectedIndexChanged;

            pictureBox1.Image = Image.FromFile("logo.png");
        }

        private void CmbEtichette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEtichette.SelectedIndex <= 0)
            {
                btnStampaEtichetta.Enabled = false;
                return;
            }

            var item = cmbEtichette.SelectedItem as ComboboxItem;
            if (item == null) { btnStampaEtichetta.Enabled = false; return; }

            _selected = _repo.GetById((int)item.Value);
            if (_selected == null) { btnStampaEtichetta.Enabled = false; return; }

            txtCodiceCorrispondente.Text = _selected.CodiceCorrispondente;
            txtStagione.Text = _selected.Stagione;
            txtTipologia.Text = _selected.Tipologia;
            txtBarcode.Text = _selected.Barcode;
            txtGenere.Text = _selected.Genere;

            txtPrezzoVendita.Text = string.IsNullOrEmpty(_selected.PrezzoVendita) ? "0" : _selected.PrezzoVendita;
            txtNumeroEtichette.Text = string.IsNullOrEmpty(_selected.NumeroEtichette) ? "1" : _selected.NumeroEtichette;

            btnStampaEtichetta.Enabled = true;
        }

        private void btnStampaEtichetta_Click(object sender, EventArgs e)
        {
            //stampa in C:\Users\Utente\Documents
            try
            {
                var zs = new ZebraPrinterService(_conf);
                //var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TemplateEtichetta.zpl");
                //var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TemplateEtichetta.prn");
                var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TemplateEtichetta.prn");
                //var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CALZATURE DONNA.prn");
                //
                var content = zs.PreparaTemplate(path, _selected, txtPrezzoVendita.Text, txtNumeroEtichette.Text);
                zs.Stampa(content);
                //MessageBox.Show("Stampa inviata","Notifica stampa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void BtnStampaEtichetta_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                var b = sender as Button;
                if (b == null) return;
                // set a distinct green and appear pressed by moving down
               // b.UseVisualStyleBackColor = false;
                b.BackColor = System.Drawing.Color.FromArgb(34, 139, 34); // darker green
                b.ForeColor = System.Drawing.Color.White;
                //b.ForeColor = System.Drawing.Color.White;
                //b.FlatStyle = FlatStyle.Flat;
                //b.FlatAppearance.BorderSize = 1;
                //b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 100, 0);
                //b.Location = new System.Drawing.Point(_btnOriginalLocation.X, _btnOriginalLocation.Y + 2);
            }
            catch { }
        }

        private void BtnStampaEtichetta_MouseUp(object sender, MouseEventArgs e)
        {
            //RestorePrintButtonVisuals();
            try
            {
                var b = sender as Button;
                if (b == null) return;
                // set a distinct green and appear pressed by moving down
                // b.UseVisualStyleBackColor = false;
                //b.BackColor = System.Drawing.Color.FromArgb(34, 139, 34); // darker green
                b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                b.ForeColor= System.Drawing.Color.Black;
                //b.ForeColor = System.Drawing.Color.White;
                //b.FlatStyle = FlatStyle.Flat;
                //b.FlatAppearance.BorderSize = 1;
                //b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 100, 0);
                //b.Location = new System.Drawing.Point(_btnOriginalLocation.X, _btnOriginalLocation.Y + 2);
            }
            catch { }
           
        }

        private void BtnStampaEtichetta_MouseLeave(object sender, EventArgs e)
        {
            // if mouse leaves while pressed, ensure we restore visuals
            //RestorePrintButtonVisuals();
            //RestorePrintButtonVisuals();
            try
            {
                var b = sender as Button;
                if (b == null) return;
                // set a distinct green and appear pressed by moving down
                // b.UseVisualStyleBackColor = false;
                //b.BackColor = System.Drawing.Color.FromArgb(34, 139, 34); // darker green
                b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                b.ForeColor = System.Drawing.Color.Black;
                //b.ForeColor = System.Drawing.Color.White;
                //b.FlatStyle = FlatStyle.Flat;
                //b.FlatAppearance.BorderSize = 1;
                //b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 100, 0);
                //b.Location = new System.Drawing.Point(_btnOriginalLocation.X, _btnOriginalLocation.Y + 2);
            }
            catch { }
           
        }

        //private void RestorePrintButtonVisuals()
        //{
        //    try
        //    {
        //        btnStampaEtichetta.BackColor = _btnOriginalBackColor;
        //        btnStampaEtichetta.ForeColor = _btnOriginalForeColor;
        //        btnStampaEtichetta.Location = _btnOriginalLocation;
        //        btnStampaEtichetta.FlatStyle = _btnOriginalFlatStyle;
        //        btnStampaEtichetta.UseVisualStyleBackColor = true;
        //    }
        //    catch { }
        //}

        private void cmbEtichette_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPrezzoVendita.Focus();
            // Seleziona tutto il testo dopo che il focus è stato applicato
            this.BeginInvoke(new Action(() => { txtPrezzoVendita.SelectAll(); }));

        }
    }

    internal class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString() { return Text; }
    }
}
