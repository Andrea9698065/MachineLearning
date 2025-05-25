namespace ProgettoML
{
    public partial class Form1 : Form
    {
        // TextBox per tutti i parametri del modello
        private TextBox txtId, txtMSSubClass, txtLotFrontage, txtLotArea, txtOverallQual, txtOverallCond;
        private TextBox txtYearBuilt, txtYearRemodAdd, txtMasVnrArea, txtBsmtFinSF1, txtBsmtFinSF2, txtBsmtUnfSF;
        private TextBox txtTotalBsmtSF, txt1stFlrSF, txt2ndFlrSF, txtLowQualFinSF, txtGrLivArea;
        private TextBox txtBsmtFullBath, txtBsmtHalfBath, txtFullBath, txtHalfBath, txtBedroomAbvGr;
        private TextBox txtKitchenAbvGr, txtTotRmsAbvGrd, txtFireplaces, txtGarageYrBlt, txtGarageCars;
        private TextBox txtGarageArea, txtWoodDeckSF, txtOpenPorchSF, txtEnclosedPorch, txt3SsnPorch;
        private TextBox txtScreenPorch, txtPoolArea, txtMiscVal, txtMoSold, txtYrSold;

        // Variabile per la modalità notte
        private bool isDarkMode = false;

        // Colori tema
        private readonly Color lightBackground = Color.White;
        private readonly Color darkBackground = Color.FromArgb(45, 45, 48);
        private readonly Color lightPanel = Color.FromArgb(240, 240, 240);
        private readonly Color darkPanel = Color.FromArgb(37, 37, 38);
        private readonly Color lightText = Color.Black;
        private readonly Color darkText = Color.White;
        private readonly Color accentColor = Color.FromArgb(70, 130, 180); // Steel Blue
        private readonly Color accentColorHover = Color.FromArgb(100, 150, 200);

        public Form1()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            // Personalizza il form principale
            this.Text = "Predittore Valore Immobiliare ML";
            this.BackColor = lightBackground;

            // Aggiungi bordi ai pannelli
            AddBordersToControls();

            // Personalizza i bottoni
            CustomizeButtons();

            // Personalizza il radio button
            CustomizeRadioButton();

            // Personalizza il titolo
            CustomizeTitle();
        }

        private void AddBordersToControls()
        {
            // Aggiungi bordi ai TableLayoutPanel
            tableLayoutPanel4.BackColor = lightPanel;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel5.BackColor = lightPanel;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel3.BackColor = lightPanel;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Aggiungi margine ai pannelli principali
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel3.Padding = new Padding(10);
        }

        private void CustomizeButtons()
        {
            CustomizeButton(button1, "🔍 Calcola Previsione");
            CustomizeButton(button2, "💾 Salva Dati");
            CustomizeButton(button3, "🔄 Reset");
        }

        private void CustomizeButton(Button btn, string text)
        {
            btn.Text = text;
            btn.BackColor = accentColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Eventi per l'effetto hover
            btn.MouseEnter += Button_MouseEnter;
            btn.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = accentColorHover;
                btn.Size = new Size(btn.Size.Width + 5, btn.Size.Height + 3);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = accentColor;
                // Ripristina la dimensione originale usando Dock
                btn.Size = btn.Parent.Size;
            }
        }

        private void CustomizeRadioButton()
        {
            radioButton1.Text = "🌙 Modalità Notte";
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioButton1.ForeColor = accentColor;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
        }

        private void CustomizeTitle()
        {
            label1.Text = "🏠 SISTEMA DI VALUTAZIONE IMMOBILIARE AI";
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = accentColor;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isDarkMode = radioButton1.Checked;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                // Modalità notte
                this.BackColor = darkBackground;
                tableLayoutPanel1.BackColor = darkBackground;
                tableLayoutPanel2.BackColor = darkBackground;
                tableLayoutPanel4.BackColor = darkPanel;
                tableLayoutPanel5.BackColor = darkPanel;
                tableLayoutPanel3.BackColor = darkPanel;

                label1.ForeColor = Color.FromArgb(100, 150, 200);
                radioButton1.ForeColor = Color.FromArgb(100, 150, 200);

                // Applica tema scuro ai controlli
                ApplyDarkThemeToControls(this);
            }
            else
            {
                // Modalità giorno
                this.BackColor = lightBackground;
                tableLayoutPanel1.BackColor = lightBackground;
                tableLayoutPanel2.BackColor = lightBackground;
                tableLayoutPanel4.BackColor = lightPanel;
                tableLayoutPanel5.BackColor = lightPanel;
                tableLayoutPanel3.BackColor = lightPanel;

                label1.ForeColor = accentColor;
                radioButton1.ForeColor = accentColor;

                // Applica tema chiaro ai controlli
                ApplyLightThemeToControls(this);
            }
        }

        private void ApplyDarkThemeToControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    control.BackColor = Color.FromArgb(60, 60, 60);
                    control.ForeColor = darkText;
                }
                else if (control is Label && control != label1)
                {
                    control.ForeColor = darkText;
                }

                // Applica ricorsivamente ai controlli figli
                if (control.HasChildren)
                {
                    ApplyDarkThemeToControls(control);
                }
            }
        }

        private void ApplyLightThemeToControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = lightText;
                }
                else if (control is Label && control != label1)
                {
                    control.ForeColor = lightText;
                }

                // Applica ricorsivamente ai controlli figli
                if (control.HasChildren)
                {
                    ApplyLightThemeToControls(control);
                }
            }
        }

        private void CreaTabellaDinamica()
        {
            // Configura il tableLayoutPanel4 esistente per contenere i controlli ML
            tableLayoutPanel4.ColumnCount = 4; // 4 colonne per label/textbox pairs
            tableLayoutPanel4.RowCount = 18; // Numero di righe necessarie

            // Pulisci le colonne esistenti e riconfigura
            tableLayoutPanel4.ColumnStyles.Clear();
            tableLayoutPanel4.RowStyles.Clear();

            // Configura le colonne (25% ciascuna)
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }

            // Configura le righe con dimensione automatica
            for (int i = 0; i < 18; i++)
            {
                tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Abilita lo scroll se necessario
            tableLayoutPanel4.AutoScroll = true;

            // Inizializza le TextBox
            InitializeTextBoxes();

            // Aggiungi i controlli al TableLayoutPanel esistente
            AddControlsToTable();

            // Configura la textBoxOutput esistente
            textBoxOutput.Multiline = true;
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Font = new Font("Consolas", 9F);
            textBoxOutput.BackColor = Color.FromArgb(248, 248, 248);
        }

        private void InitializeTextBoxes()
        {
            txtId = CreateStyledTextBox("2");
            txtMSSubClass = CreateStyledTextBox("20");
            txtLotFrontage = CreateStyledTextBox("800");
            txtLotArea = CreateStyledTextBox("9600");
            txtOverallQual = CreateStyledTextBox("6");
            txtOverallCond = CreateStyledTextBox("8");
            txtYearBuilt = CreateStyledTextBox("1976");
            txtYearRemodAdd = CreateStyledTextBox("1976");
            txtMasVnrArea = CreateStyledTextBox("0");
            txtBsmtFinSF1 = CreateStyledTextBox("978");
            txtBsmtFinSF2 = CreateStyledTextBox("0");
            txtBsmtUnfSF = CreateStyledTextBox("284");
            txtTotalBsmtSF = CreateStyledTextBox("1262");
            txt1stFlrSF = CreateStyledTextBox("1262");
            txt2ndFlrSF = CreateStyledTextBox("0");
            txtLowQualFinSF = CreateStyledTextBox("0");
            txtGrLivArea = CreateStyledTextBox("1262");
            txtBsmtFullBath = CreateStyledTextBox("0");
            txtBsmtHalfBath = CreateStyledTextBox("1");
            txtFullBath = CreateStyledTextBox("2");
            txtHalfBath = CreateStyledTextBox("0");
            txtBedroomAbvGr = CreateStyledTextBox("3");
            txtKitchenAbvGr = CreateStyledTextBox("1");
            txtTotRmsAbvGrd = CreateStyledTextBox("6");
            txtFireplaces = CreateStyledTextBox("1");
            txtGarageYrBlt = CreateStyledTextBox("1976");
            txtGarageCars = CreateStyledTextBox("2");
            txtGarageArea = CreateStyledTextBox("460");
            txtWoodDeckSF = CreateStyledTextBox("298");
            txtOpenPorchSF = CreateStyledTextBox("0");
            txtEnclosedPorch = CreateStyledTextBox("0");
            txt3SsnPorch = CreateStyledTextBox("0");
            txtScreenPorch = CreateStyledTextBox("0");
            txtPoolArea = CreateStyledTextBox("0");
            txtMiscVal = CreateStyledTextBox("0");
            txtMoSold = CreateStyledTextBox("5");
            txtYrSold = CreateStyledTextBox("2007");
        }

        private TextBox CreateStyledTextBox(string defaultValue)
        {
            return new TextBox()
            {
                Text = defaultValue,
                Dock = DockStyle.Fill,
                Margin = new Padding(3),
                Font = new Font("Segoe UI", 9F),
                TextAlign = HorizontalAlignment.Center,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private void AddControlsToTable()
        {
            int row = 0;

            // Prima colonna di controlli (colonne 0-1)
            AddLabelAndTextBox("🆔 Id:", txtId, 0, row++);
            AddLabelAndTextBox("🏘️ MS SubClass:", txtMSSubClass, 0, row++);
            AddLabelAndTextBox("📏 Lot Frontage:", txtLotFrontage, 0, row++);
            AddLabelAndTextBox("📐 Lot Area:", txtLotArea, 0, row++);
            AddLabelAndTextBox("⭐ Overall Qual:", txtOverallQual, 0, row++);
            AddLabelAndTextBox("🔧 Overall Cond:", txtOverallCond, 0, row++);
            AddLabelAndTextBox("📅 Year Built:", txtYearBuilt, 0, row++);
            AddLabelAndTextBox("🔨 Year Remod:", txtYearRemodAdd, 0, row++);
            AddLabelAndTextBox("🧱 Mas Vnr Area:", txtMasVnrArea, 0, row++);
            AddLabelAndTextBox("🏠 Bsmt Fin SF1:", txtBsmtFinSF1, 0, row++);
            AddLabelAndTextBox("🏠 Bsmt Fin SF2:", txtBsmtFinSF2, 0, row++);
            AddLabelAndTextBox("📦 Bsmt Unf SF:", txtBsmtUnfSF, 0, row++);
            AddLabelAndTextBox("📊 Total Bsmt SF:", txtTotalBsmtSF, 0, row++);
            AddLabelAndTextBox("1️⃣ 1st Flr SF:", txt1stFlrSF, 0, row++);
            AddLabelAndTextBox("2️⃣ 2nd Flr SF:", txt2ndFlrSF, 0, row++);
            AddLabelAndTextBox("📉 Low Qual SF:", txtLowQualFinSF, 0, row++);
            AddLabelAndTextBox("🏡 Gr Liv Area:", txtGrLivArea, 0, row++);
            AddLabelAndTextBox("🛁 Bsmt Full Bath:", txtBsmtFullBath, 0, row++);

            row = 0; // Reset per seconda colonna

            // Seconda colonna di controlli (colonne 2-3)
            AddLabelAndTextBox("🚿 Bsmt Half Bath:", txtBsmtHalfBath, 2, row++);
            AddLabelAndTextBox("🛀 Full Bath:", txtFullBath, 2, row++);
            AddLabelAndTextBox("🚽 Half Bath:", txtHalfBath, 2, row++);
            AddLabelAndTextBox("🛏️ Bedroom Abv:", txtBedroomAbvGr, 2, row++);
            AddLabelAndTextBox("🍳 Kitchen Abv:", txtKitchenAbvGr, 2, row++);
            AddLabelAndTextBox("🏠 Tot Rms Abv:", txtTotRmsAbvGrd, 2, row++);
            AddLabelAndTextBox("🔥 Fireplaces:", txtFireplaces, 2, row++);
            AddLabelAndTextBox("🚗 Garage Yr:", txtGarageYrBlt, 2, row++);
            AddLabelAndTextBox("🚙 Garage Cars:", txtGarageCars, 2, row++);
            AddLabelAndTextBox("📦 Garage Area:", txtGarageArea, 2, row++);
            AddLabelAndTextBox("🌲 Wood Deck SF:", txtWoodDeckSF, 2, row++);
            AddLabelAndTextBox("🏞️ Open Porch:", txtOpenPorchSF, 2, row++);
            AddLabelAndTextBox("🏠 Enclosed Porch:", txtEnclosedPorch, 2, row++);
            AddLabelAndTextBox("🌤️ 3Ssn Porch:", txt3SsnPorch, 2, row++);
            AddLabelAndTextBox("🪟 Screen Porch:", txtScreenPorch, 2, row++);
            AddLabelAndTextBox("🏊 Pool Area:", txtPoolArea, 2, row++);
            AddLabelAndTextBox("💰 Misc Val:", txtMiscVal, 2, row++);
            AddLabelAndTextBox("📅 Mo Sold:", txtMoSold, 2, row++);
            AddLabelAndTextBox("📆 Yr Sold:", txtYrSold, 2, row++);
        }

        private void AddLabelAndTextBox(string labelText, TextBox textBox, int startCol, int row)
        {
            Label label = new Label();
            label.Text = labelText;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleRight;
            label.Margin = new Padding(3);
            label.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

            tableLayoutPanel4.Controls.Add(label, startCol, row);
            tableLayoutPanel4.Controls.Add(textBox, startCol + 1, row);
        }

        private float ParseFloatSafe(TextBox textBox, float defaultValue = 0f)
        {
            if (float.TryParse(textBox.Text, out float result))
                return result;
            return defaultValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreaTabellaDinamica();
            ApplyTheme(); // Applica il tema iniziale
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea un'istanza del modello leggendo i valori dalle TextBox
                var sampleData = new MLModel1.ModelInput()
                {
                    Id = ParseFloatSafe(txtId, 2F),
                    MSSubClass = ParseFloatSafe(txtMSSubClass, 20F),
                    LotFrontage = ParseFloatSafe(txtLotFrontage, 800F),
                    LotArea = ParseFloatSafe(txtLotArea, 9600F),
                    OverallQual = ParseFloatSafe(txtOverallQual, 6F),
                    OverallCond = ParseFloatSafe(txtOverallCond, 8F),
                    YearBuilt = ParseFloatSafe(txtYearBuilt, 1976F),
                    YearRemodAdd = ParseFloatSafe(txtYearRemodAdd, 1976F),
                    MasVnrArea = ParseFloatSafe(txtMasVnrArea, 0F),
                    BsmtFinSF1 = ParseFloatSafe(txtBsmtFinSF1, 978F),
                    BsmtFinSF2 = ParseFloatSafe(txtBsmtFinSF2, 0F),
                    BsmtUnfSF = ParseFloatSafe(txtBsmtUnfSF, 284F),
                    TotalBsmtSF = ParseFloatSafe(txtTotalBsmtSF, 1262F),
                    _1stFlrSF = ParseFloatSafe(txt1stFlrSF, 1262F),
                    _2ndFlrSF = ParseFloatSafe(txt2ndFlrSF, 0F),
                    LowQualFinSF = ParseFloatSafe(txtLowQualFinSF, 0F),
                    GrLivArea = ParseFloatSafe(txtGrLivArea, 1262F),
                    BsmtFullBath = ParseFloatSafe(txtBsmtFullBath, 0F),
                    BsmtHalfBath = ParseFloatSafe(txtBsmtHalfBath, 1F),
                    FullBath = ParseFloatSafe(txtFullBath, 2F),
                    HalfBath = ParseFloatSafe(txtHalfBath, 0F),
                    BedroomAbvGr = ParseFloatSafe(txtBedroomAbvGr, 3F),
                    KitchenAbvGr = ParseFloatSafe(txtKitchenAbvGr, 1F),
                    TotRmsAbvGrd = ParseFloatSafe(txtTotRmsAbvGrd, 6F),
                    Fireplaces = ParseFloatSafe(txtFireplaces, 1F),
                    GarageYrBlt = ParseFloatSafe(txtGarageYrBlt, 1976F),
                    GarageCars = ParseFloatSafe(txtGarageCars, 2F),
                    GarageArea = ParseFloatSafe(txtGarageArea, 460F),
                    WoodDeckSF = ParseFloatSafe(txtWoodDeckSF, 298F),
                    OpenPorchSF = ParseFloatSafe(txtOpenPorchSF, 0F),
                    EnclosedPorch = ParseFloatSafe(txtEnclosedPorch, 0F),
                    _3SsnPorch = ParseFloatSafe(txt3SsnPorch, 0F),
                    ScreenPorch = ParseFloatSafe(txtScreenPorch, 0F),
                    PoolArea = ParseFloatSafe(txtPoolArea, 0F),
                    MiscVal = ParseFloatSafe(txtMiscVal, 0F),
                    MoSold = ParseFloatSafe(txtMoSold, 5F),
                    YrSold = ParseFloatSafe(txtYrSold, 2007F)
                };

                // Esegui la previsione
                var prediction = MLModel1.Predict(sampleData);

                // Mostra il risultato nella TextBox di output esistente
                textBoxOutput.Text = $"💰 VALORE PREVISTO DELLA CASA: {prediction.Score:C}\r\n" +
                                   $"📅 Data previsione: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n" +
                                   $"\r\n📊 PARAMETRI UTILIZZATI:\r\n" +
                                   $"🏞️ Area lotto: {sampleData.LotArea:N0} sq ft\r\n" +
                                   $"📅 Anno costruzione: {sampleData.YearBuilt}\r\n" +
                                   $"⭐ Qualità generale: {sampleData.OverallQual}/10\r\n" +
                                   $"🏡 Area abitabile: {sampleData.GrLivArea:N0} sq ft\r\n" +
                                   $"🛏️ Camere da letto: {sampleData.BedroomAbvGr}\r\n" +
                                   $"🛀 Bagni completi: {sampleData.FullBath}\r\n" +
                                   $"🚗 Posti auto garage: {sampleData.GarageCars}\r\n" +
                                   $"🔥 Camini: {sampleData.Fireplaces}";
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = $"❌ ERRORE DURANTE LA PREVISIONE:\r\n{ex.Message}\r\n\r\n" +
                                   $"💡 Suggerimento: Controlla che tutti i valori inseriti siano numerici validi.";
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            // Stesso codice del button1_Click per mantenere compatibilità
            button1_Click(sender, e);
        }
    }
}