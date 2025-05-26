using System.Windows.Forms;

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

        // Variabile per la modalità notte / Gionrno. Se false  ==> Giorno , se True ==> Notte
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
           
           
            this.BackColor = lightBackground;

            
            AddBordersToControls();//Personalizzazzione Bordi

            
            CustomizeButtons();// Personalizzazzione i bottoni

            
            CustomizeRadioButton();// Personalizzazzione il radio button

            
            CustomizeTitle();// Personalizzazzione titolo
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

        private void CustomizeButtons()//Personalizzazzione singoli bottoni con simboli
        {
            CustomizeButton(button1, "🔍 Calcola Previsione");
            CustomizeButton(button4, "💾 Salva Dati");
            CustomizeButton(button3, "🔄 Reset");
            CustomizeButton(btnTest1, "BottoneTest1");

            CustomizeButton(btnTest2, "BottoneTest2");
            CustomizeButton(btnTest3, "BottoneTest3");
            CustomizeButton(btnResetCronologia, "🗑️ Cancella Cronologia");
            CustomizeButton(button2, "📝 README");
        }

        private void CustomizeButton(Button btn, string text)//Personalizzazzione comune per tutti i bottoni.
        {
            //Aggiunge proprietà base
            btn.Text = text;
            btn.BackColor = accentColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            //Piccolo effetto con l'interazione del bottone 
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
                
                btn.Size = btn.Parent.Size;
            }
        }

        private void CustomizeRadioButton()
        {
            radioButton1.Text = isDarkMode ? "☀️ Modalità Giorno" : "🌙 Modalità Notte";
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioButton1.ForeColor = accentColor;
            radioButton1.Checked = false; // Default: modalità giorno
            radioButton1.Text = isDarkMode ? "☀️ Modalità Giorno" : "🌙 Modalità Notte";
            radioButton1.AutoCheck = false;
            radioButton1.Click += RadioButton1_Click;
        }

        private void CustomizeTitle()//Peronalizzazzione Titolo
        {
            label1.Text = "🏠 SISTEMA DI VALUTAZIONE IMMOBILIARE CON MACHINE LEARNING";
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = accentColor;


        }
        private void RadioButton1_Click(object sender, EventArgs e)//Scambio giorno notte 
        {

            isDarkMode = !isDarkMode;
            radioButton1.Checked = isDarkMode;
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

                // Applica tema scuro
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

                // Applica tema chiaro 
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

              
                if (control.HasChildren)
                {
                    ApplyLightThemeToControls(control);
                }
            }
        }


        private void CreaTabellaDinamica()//Personalizza Tabella : tablelayoutpanell4
        {
            
            tableLayoutPanel4.ColumnCount = 4; // 4 colonne per label/textbox pairs
            tableLayoutPanel4.RowCount = 18; // Numero di righe necessarie

            
            tableLayoutPanel4.ColumnStyles.Clear();
            tableLayoutPanel4.RowStyles.Clear();

            // Configura le colonne
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }

            // Configura le righe
            for (int i = 0; i < 18; i++)
            {
                tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            //scroll
            tableLayoutPanel4.AutoScroll = true;

            //Inizializzo TextBox
            InitializeTextBoxes();
            AddControlsToTable();

            
            textBoxOutput.Multiline = true;
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Font = new Font("Consolas", 9F);
            textBoxOutput.BackColor = Color.FromArgb(248, 248, 248);
        }

        private void InitializeTextBoxes()//Quando inizializzo il programma metto dei valori di "base"
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
            AddLabelAndTextBox("1️°  1st Flr SF:", txt1stFlrSF, 0, row++);
            AddLabelAndTextBox("2️°  2nd Flr SF:", txt2ndFlrSF, 0, row++);
            AddLabelAndTextBox("📉 Low Qual SF:", txtLowQualFinSF, 0, row++);
            AddLabelAndTextBox("🏡 Gr Liv Area:", txtGrLivArea, 0, row++);
            AddLabelAndTextBox("🛁 Bsmt Full Bath:", txtBsmtFullBath, 0, row++);
            AddLabelAndTextBox("📆 Yr Sold:", txtYrSold, 0, row++);
            row = 0; 

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
            ApplyTheme(); 
        }

        private void button1_Click(object sender, EventArgs e)//Bottone Per La Previsione
        {
            try//prova a prendere i dati
            {

                var sampleData = new MLModel1.ModelInput()//Prende i dati
                {

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

            
                var prediction = MLModel1.Predict(sampleData);//chiama il modello per fare la previsione

                
                string nuovoRisultato = $"💰 VALORE PREVISTO: {prediction.Score:C}\r\n" +
                                       $"📅 Data: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n" +
                                       $"{"".PadRight(50, '=')}\r\n\r\n";

                // Se la textbox non è vuota, aggiungi il nuovo risultato sopra
                if (!string.IsNullOrEmpty(textBoxOutput.Text))
                {
                    textBoxOutput.Text = nuovoRisultato + textBoxOutput.Text;
                }
                else
                {
                    textBoxOutput.Text = nuovoRisultato;
                }


                textBoxOutput.SelectionStart = 0;
                textBoxOutput.ScrollToCaret();

            }
            catch (Exception ex)//Se c'è un errore
            {
                string erroreMessage = $"❌ ERRORE: {ex.Message}\r\n" +
                                      $"📅 Data: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n" +
                                      $"{"".PadRight(50, '=')}\r\n\r\n";

                if (!string.IsNullOrEmpty(textBoxOutput.Text))
                {
                    textBoxOutput.Text = erroreMessage + textBoxOutput.Text;
                }
                else
                {
                    textBoxOutput.Text = erroreMessage;
                }

                textBoxOutput.SelectionStart = 0;
                textBoxOutput.ScrollToCaret();
            }
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            txtMSSubClass.Text = "60";
            txtLotFrontage.Text = "108";
            txtLotArea.Text = "13418";
            txtOverallQual.Text = "8";
            txtOverallCond.Text = "5";
            txtYearBuilt.Text = "2004";
            txtYearRemodAdd.Text = "2005";
            txtMasVnrArea.Text = "132";
            txtBsmtFinSF1.Text = "1117";
            txtBsmtFinSF2.Text = "0";
            txtBsmtUnfSF.Text = "0";
            txtTotalBsmtSF.Text = "1117";
            txt1stFlrSF.Text = "1132";
            txt2ndFlrSF.Text = "1320";
            txtLowQualFinSF.Text = "0";
            txtGrLivArea.Text = "2452";
            txtBsmtFullBath.Text = "1";
            txtBsmtHalfBath.Text = "0";
            txtFullBath.Text = "3";
            txtHalfBath.Text = "1";
            txtBedroomAbvGr.Text = "4";
            txtKitchenAbvGr.Text = "1";
            txtTotRmsAbvGrd.Text = "9";
            txtFireplaces.Text = "1";
            txtGarageYrBlt.Text = "2004";
            txtGarageCars.Text = "3";
            txtGarageArea.Text = "691";
            txtWoodDeckSF.Text = "113";
            txtOpenPorchSF.Text = "32";
            txtEnclosedPorch.Text = "0";
            txt3SsnPorch.Text = "0";
            txtScreenPorch.Text = "0";
            txtPoolArea.Text = "0";
            txtMiscVal.Text = "0";
            txtMoSold.Text = "2";
            txtYrSold.Text = "2006";


        }


        private void btnTest2_Click(object sender, EventArgs e)
        {
            txtMSSubClass.Text = "20";
            txtLotFrontage.Text = "75";
            txtLotArea.Text = "10084";
            txtOverallQual.Text = "8";
            txtOverallCond.Text = "5";
            txtYearBuilt.Text = "2004";
            txtYearRemodAdd.Text = "2005";
            txtMasVnrArea.Text = "186";
            txtBsmtFinSF1.Text = "1369";
            txtBsmtFinSF2.Text = "0";
            txtBsmtUnfSF.Text = "317";
            txtTotalBsmtSF.Text = "1686";
            txt1stFlrSF.Text = "1694";
            txt2ndFlrSF.Text = "806";
            txtLowQualFinSF.Text = "0";
            txtGrLivArea.Text = "2500";
            txtBsmtFullBath.Text = "1";
            txtBsmtHalfBath.Text = "0";
            txtFullBath.Text = "2";
            txtHalfBath.Text = "1";
            txtBedroomAbvGr.Text = "3";
            txtKitchenAbvGr.Text = "1";
            txtTotRmsAbvGrd.Text = "8";
            txtFireplaces.Text = "1";
            txtGarageYrBlt.Text = "2004";
            txtGarageCars.Text = "2";
            txtGarageArea.Text = "522";
            txtWoodDeckSF.Text = "255";
            txtOpenPorchSF.Text = "57";
            txtEnclosedPorch.Text = "0";
            txt3SsnPorch.Text = "0";
            txtScreenPorch.Text = "0";
            txtPoolArea.Text = "0";
            txtMiscVal.Text = "0";
            txtMoSold.Text = "8";
            txtYrSold.Text = "2007";

        }


        private void btnTest3_Click(object sender, EventArgs e)
        {
            txtMSSubClass.Text = "20";
            txtLotFrontage.Text = "60";
            txtLotArea.Text = "7200";
            txtOverallQual.Text = "5";
            txtOverallCond.Text = "7";
            txtYearBuilt.Text = "1951";
            txtYearRemodAdd.Text = "2000";
            txtMasVnrArea.Text = "0";
            txtBsmtFinSF1.Text = "234";
            txtBsmtFinSF2.Text = "486";
            txtBsmtUnfSF.Text = "180";
            txtTotalBsmtSF.Text = "900";
            txt1stFlrSF.Text = "900";
            txt2ndFlrSF.Text = "0";
            txtLowQualFinSF.Text = "0";
            txtGrLivArea.Text = "900";
            txtBsmtFullBath.Text = "0";
            txtBsmtHalfBath.Text = "1";
            txtFullBath.Text = "1";
            txtHalfBath.Text = "0";
            txtBedroomAbvGr.Text = "3";
            txtKitchenAbvGr.Text = "1";
            txtTotRmsAbvGrd.Text = "5";
            txtFireplaces.Text = "0";
            txtGarageYrBlt.Text = "2005";
            txtGarageCars.Text = "2";
            txtGarageArea.Text = "576";
            txtWoodDeckSF.Text = "222";
            txtOpenPorchSF.Text = "32";
            txtEnclosedPorch.Text = "0";
            txt3SsnPorch.Text = "0";
            txtScreenPorch.Text = "0";
            txtPoolArea.Text = "0";
            txtMiscVal.Text = "0";
            txtMoSold.Text = "5";
            txtYrSold.Text = "2010";
        }


        private void btnResetCronologia_Click(object sender, EventArgs e)//Resetto la cronologia
        {

            textBoxOutput.Text = "";


            textBoxOutput.Text = "🗑️ Cronologia cancellata\r\n" +
                               $"📅 {DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n" +
                               $"{"".PadRight(50, '=')}\r\n\r\n";
        }

        private void button4_Click_1(object sender, EventArgs e)//Salvo il file
        {

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File di testo (*.txt)|*.txt";
                saveFileDialog.Title = "Salva dati previsione";
                saveFileDialog.FileName = $"PrevisioneImmobiliare_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string contenuto = "";

                  
                    if (!string.IsNullOrEmpty(textBoxOutput.Text))
                    {
                        var lines = textBoxOutput.Text.Split('\n');
                        string valorePrevisto = "Non calcolato";
                        string dataPrevisione = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                        foreach (var line in lines)
                        {
                            if (line.Contains("VALORE PREVISTO:"))
                            {
                                valorePrevisto = line.Replace("💰 VALORE PREVISTO:", "").Trim();
                                break;
                            }
                        }

                        contenuto += $"-Valore Previsto: {valorePrevisto}\n";
                        contenuto += $"-Data: {dataPrevisione}\n";
                    }
                    else
                    {
                        contenuto += $"-Valore Previsto: Non calcolato\n";
                        contenuto += $"-Data: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n";
                    }

                    contenuto += "DATI:\n";
                    contenuto += $"-MS SubClass: {txtMSSubClass.Text}\n";
                    contenuto += $"-Lot Frontage: {txtLotFrontage.Text}\n";
                    contenuto += $"-Lot Area: {txtLotArea.Text}\n";
                    contenuto += $"-Overall Qual: {txtOverallQual.Text}\n";
                    contenuto += $"-Overall Cond: {txtOverallCond.Text}\n";
                    contenuto += $"-Year Built: {txtYearBuilt.Text}\n";
                    contenuto += $"-Year Remod: {txtYearRemodAdd.Text}\n";
                    contenuto += $"-Mas Vnr Area: {txtMasVnrArea.Text}\n";
                    contenuto += $"-Bsmt Fin SF1: {txtBsmtFinSF1.Text}\n";
                    contenuto += $"-Bsmt Fin SF2: {txtBsmtFinSF2.Text}\n";
                    contenuto += $"-Bsmt Unf SF: {txtBsmtUnfSF.Text}\n";
                    contenuto += $"-Total Bsmt SF: {txtTotalBsmtSF.Text}\n";
                    contenuto += $"-1st Flr SF: {txt1stFlrSF.Text}\n";
                    contenuto += $"-2nd Flr SF: {txt2ndFlrSF.Text}\n";
                    contenuto += $"-Low Qual SF: {txtLowQualFinSF.Text}\n";
                    contenuto += $"-Gr Liv Area: {txtGrLivArea.Text}\n";
                    contenuto += $"-Bsmt Full Bath: {txtBsmtFullBath.Text}\n";
                    contenuto += $"-Bsmt Half Bath: {txtBsmtHalfBath.Text}\n";
                    contenuto += $"-Full Bath: {txtFullBath.Text}\n";
                    contenuto += $"-Half Bath: {txtHalfBath.Text}\n";
                    contenuto += $"-Bedroom Abv: {txtBedroomAbvGr.Text}\n";
                    contenuto += $"-Kitchen Abv: {txtKitchenAbvGr.Text}\n";
                    contenuto += $"-Tot Rms Abv: {txtTotRmsAbvGrd.Text}\n";
                    contenuto += $"-Fireplaces: {txtFireplaces.Text}\n";
                    contenuto += $"-Garage Yr: {txtGarageYrBlt.Text}\n";
                    contenuto += $"-Garage Cars: {txtGarageCars.Text}\n";
                    contenuto += $"-Garage Area: {txtGarageArea.Text}\n";
                    contenuto += $"-Wood Deck SF: {txtWoodDeckSF.Text}\n";
                    contenuto += $"-Open Porch: {txtOpenPorchSF.Text}\n";
                    contenuto += $"-Enclosed Porch: {txtEnclosedPorch.Text}\n";
                    contenuto += $"-3Ssn Porch: {txt3SsnPorch.Text}\n";
                    contenuto += $"-Screen Porch: {txtScreenPorch.Text}\n";
                    contenuto += $"-Pool Area: {txtPoolArea.Text}\n";
                    contenuto += $"-Misc Val: {txtMiscVal.Text}\n";
                    contenuto += $"-Mo Sold: {txtMoSold.Text}\n";
                    contenuto += $"-Yr Sold: {txtYrSold.Text}\n";

                    File.WriteAllText(saveFileDialog.FileName, contenuto);

                    MessageBox.Show($"Dati salvati correttamente in:\n{saveFileDialog.FileName}",
                                  "Salvataggio completato",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il salvataggio:\n{ex.Message}",
                               "Errore",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = "2";
            txtMSSubClass.Text = "20";
            txtLotFrontage.Text = "800";
            txtLotArea.Text = "9600";
            txtOverallQual.Text = "6";
            txtOverallCond.Text = "8";
            txtYearBuilt.Text = "1976";
            txtYearRemodAdd.Text = "1976";
            txtMasVnrArea.Text = "0";
            txtBsmtFinSF1.Text = "978";
            txtBsmtFinSF2.Text = "0";
            txtBsmtUnfSF.Text = "284";
            txtTotalBsmtSF.Text = "1262";
            txt1stFlrSF.Text = "1262";
            txt2ndFlrSF.Text = "0";
            txtLowQualFinSF.Text = "0";
            txtGrLivArea.Text = "1262";
            txtBsmtFullBath.Text = "0";
            txtBsmtHalfBath.Text = "1";
            txtFullBath.Text = "2";
            txtHalfBath.Text = "0";
            txtBedroomAbvGr.Text = "3";
            txtKitchenAbvGr.Text = "1";
            txtTotRmsAbvGrd.Text = "6";
            txtFireplaces.Text = "1";
            txtGarageYrBlt.Text = "1976";
            txtGarageCars.Text = "2";
            txtGarageArea.Text = "460";
            txtWoodDeckSF.Text = "298";
            txtOpenPorchSF.Text = "0";
            txtEnclosedPorch.Text = "0";
            txt3SsnPorch.Text = "0";
            txtScreenPorch.Text = "0";
            txtPoolArea.Text = "0";
            txtMiscVal.Text = "0";
            txtMoSold.Text = "5";
            txtYrSold.Text = "2007";



        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Bottone del README
        {
            Form infoForm = new Form
            {
                Text = "Informazioni Sistema ML",
                Size = new Size(700, 600),
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

           
            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            RichTextBox richTextBox = new RichTextBox
            {
                ReadOnly = true,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                BorderStyle = BorderStyle.FixedSingle,
                DetectUrls = true,
                ScrollBars = RichTextBoxScrollBars.Vertical
            };

          
            Panel buttonPanel = new Panel
            {
                Height = 60,
                Dock = DockStyle.Bottom,
                Padding = new Padding(0, 10, 0, 0)
            };

   
            Button btnCopia = new Button
            {
                Text = "📋 Copiami",
                Size = new Size(150, 40),
                Location = new Point(50, 10),
                BackColor = accentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCopia.FlatAppearance.BorderSize = 0;

         
            Button btnLink = new Button
            {
                Text = "🔗 Link Database",
                Size = new Size(150, 40),
                Location = new Point(220, 10),
                BackColor = Color.FromArgb(220, 20, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLink.FlatAppearance.BorderSize = 0;

           
            btnCopia.Click += (s, args) =>
            {
                try
                {
                    Clipboard.SetText(richTextBox.Text);
                    MessageBox.Show("Testo copiato negli appunti!", "Successo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nella copia: {ex.Message}", "Errore",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnLink.Click += (s, args) =>
            {
                try
                {
                    string url = "https://www.kaggle.com/code/gusthema/house-prices-prediction-using-tfdf/input?select=train.csv";
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Impossibile aprire il link: {ex.Message}", "Errore",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            
            btnCopia.MouseEnter += (s, args) => btnCopia.BackColor = accentColorHover;
            btnCopia.MouseLeave += (s, args) => btnCopia.BackColor = accentColor;
            btnLink.MouseEnter += (s, args) => btnLink.BackColor = Color.FromArgb(255, 69, 101);
            btnLink.MouseLeave += (s, args) => btnLink.BackColor = Color.FromArgb(220, 20, 60);

           //Contenuto del README
            richTextBox.Text =

@"🏠 SISTEMA DI VALUTAZIONE IMMOBILIARE CON MACHINE LEARNING
📌 OBIETTIVO
Creare un modello di Machine Learning supervisionato che preveda il prezzo degli immobili da input utente.

[CONSEGNA COMPLETA]

Sviluppare un modello di supervised learning in Python (usando scikit-learn, pandas o simili) oppure C# machine learning platform,
capace di apprendere da un dataset reale e restituire previsioni credibili su nuovi input.
Scegli un dataset da una fonte affidabile (Kaggle, UCI, OpenML) e descrivilo brevemente.
Pulisci e prepara i dati (gestione dei null, normalizzazione, train-test split).
Applica almeno un algoritmo supervisionato (es. Decision Tree, KNN, SVM, Logistic Regression).
Valuta le prestazioni del modello con metriche appropriate.
Testa il modello con almeno tre input inventati ma realistici.
Concludi con una breve riflessione su efficacia e limiti del lavoro.
Il link alla repository GIT con dataset e codice del machine learning, inoltre consegnare una presentazione che spieghi i procedimenti e l'algoritmo di machine learning scelto
    
[CONSEGNA COMPLETA]

📊 DATASET
• Fonte: Kaggle - House Prices Dataset
• Contenuto: Informazioni dettagliate su proprietà immobiliari
• Variabili: Superficie, numero stanze, anno costruzione, qualità, condizioni, garage, ecc.


📐 PREPROCESSING DEI DATI
• Pulizia dati: Rimozione valori nulli e anomali
• Split Dataset: 80% training / 20% testing

🧠 MODELLO UTILIZZATO
• Algoritmo Principale: LightGbmRegression
• Precisione pari a 86%


🖥️ INTERFACCIA UTENTE
• Windows Forms (C# .NET)
• Funzionalità:
  - Input interattivo 
  - Calcolo previsione in tempo reale
  - Cronologia delle valutazioni
  - Salvataggio dati in formato TXT
  - 3 esempi precaricati per test rapidi
  - Modalità Dark/Light theme
  - Reset completo dei dati

⚙️ CARATTERISTICHE TECNICHE
• Linguaggio: C# con ML.NET
• Framework: .NET Framework/Core
• Librerie: System.Windows.Forms, ML.NET
• Architettura: Single-form application con componenti modulari

⚠️ LIMITAZIONI E CONSIDERAZIONI
• Dataset non aggiornato alle condizioni di mercato attuali
• Modello addestrato su dati specifici (geograficamente limitati)
• Possibili discrepanze per immobili con caratteristiche anomale
• Non considera fattori esterni (economia, politiche, eventi)

📚 RIFERIMENTI TECNICI
• Documentazione: Microsoft ML.NET docs, siti online, spiegazioni in classe


🔗 RISORSE
• Dataset originale disponibile su Kaggle
• Codice sorgente documentato
• Manuale utente integrato
• Log delle versioni e aggiornamenti

🚿Esempio Con spiegazione : 
MSSubClass      ==> Tipo proprietà: Piani con garage
LotFrontage     ==> Frontale del lotto in piedi
LotArea         ==> Area del lotto
OverallQual     ==> Qualità complessiva: alta
OverallCond     ==> Condizione complessiva: media
YearBuilt       ==> Anno costruzione
YearRemodAdd    ==> Anno ristrutturazione
MasVnrArea      ==> Area rivestimento in muratura
BsmtFinSF1      ==> Seminterrato finito tipo 1
BsmtFinSF2      ==> Seminterrato finito tipo 2
BsmtUnfSF       ==> Seminterrato non finito
TotalBsmtSF     ==> Totale area seminterrato
_1stFlrSF       ==> Superficie primo piano
_2ndFlrSF       ==> Superficie secondo piano
LowQualFinSF    ==> Superficie finita bassa qualità
GrLivArea       ==> Superficie abitabile sopra terra
BsmtFullBath    ==> Bagno completo nel seminterrato
BsmtHalfBath    ==> Mezzo bagno nel seminterrato
FullBath        ==> Bagni completi
HalfBath        ==> Mezzi bagni
BedroomAbvGr    ==> Camere sopra il suolo
KitchenAbvGr    ==> Cucine sopra il suolo
TotRmsAbvGrd    ==> Totale stanze (esclusi bagni)
Fireplaces      ==> Camini
GarageYrBlt     ==> Anno costruzione garage
GarageCars      ==> Capienza garage (auto)
GarageArea      ==> Superficie garage
WoodDeckSF      ==> Superficie terrazza in legno
OpenPorchSF     ==> Superficie veranda aperta
EnclosedPorch   ==> Superficie veranda chiusa
_3SsnPorch      ==> Veranda tre stagioni
ScreenPorch     ==> Veranda con zanzariere
PoolArea        ==> Superficie piscina
MiscVal         ==> Valore oggetti extra
MoSold          ==> Mese di vendita
YrSold          ==> Anno di vendita




";

 
            if (isDarkMode)
            {
                infoForm.BackColor = darkBackground;
                mainPanel.BackColor = darkBackground;
                buttonPanel.BackColor = darkBackground;
                richTextBox.BackColor = Color.FromArgb(60, 60, 60);
                richTextBox.ForeColor = darkText;
            }
            else
            {
                infoForm.BackColor = lightBackground;
                mainPanel.BackColor = lightBackground;
                buttonPanel.BackColor = lightBackground;
                richTextBox.BackColor = Color.White;
                richTextBox.ForeColor = lightText;
            }

            buttonPanel.Controls.AddRange(new Control[] { btnCopia, btnLink });
            mainPanel.Controls.AddRange(new Control[] { richTextBox, buttonPanel });
            infoForm.Controls.Add(mainPanel);

            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = 0;

            infoForm.ShowDialog();
        }
    }





























}