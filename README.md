🏠 SISTEMA DI VALUTAZIONE IMMOBILIARE CON MACHINE LEARNING


📌 OBIETTIVO
Creare un modello di Machine Learning supervisionato che preveda il prezzo degli immobili da input utente.

[CONSEGNA]
Sviluppare un modello di supervised learning in Python (usando scikit-learn, pandas o simili) oppure C# machine learning platform,
capace di apprendere da un dataset reale e restituire previsioni credibili su nuovi input.
Scegli un dataset da una fonte affidabile (Kaggle, UCI, OpenML) e descrivilo brevemente.
Pulisci e prepara i dati (gestione dei null, normalizzazione, train-test split).
Applica almeno un algoritmo supervisionato (es. Decision Tree, KNN, SVM, Logistic Regression).
Valuta le prestazioni del modello con metriche appropriate.
Testa il modello con almeno tre input inventati ma realistici.
Concludi con una breve riflessione su efficacia e limiti del lavoro.
Il link alla repository GIT con dataset e codice del machine learning, inoltre consegnare una presentazione che spieghi i procedimenti e l'algoritmo di machine learning scelto
[CONSEGNA]
                        
📊 DATASET
• Fonte: Kaggle - House Prices Dataset
• Contenuto: Informazioni dettagliate su proprietà immobiliari
• Variabili: Superficie, numero stanze, anno costruzione, qualità, condizioni, garage, ecc.

📐 PREPROCESSING DEI DATI
• Pulizia dati: Rimozione valori nulli e anomali
• Split Dataset: 80% training / 20% testing

🧠 MODELLO UTILIZZATO
• Algoritmo Principale: Decision Tree Regressor (scikit-learn)
• Alternative Valutate: K-Nearest Neighbors, Linear Regression, Random Forest
• Ottimizzazione: Grid Search per iperparametri



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
• Pattern: Event-driven programming
• Architettura: Single-form application con componenti modulari

⚠️ LIMITAZIONI E CONSIDERAZIONI
• Dataset non aggiornato alle condizioni di mercato attuali
• Modello addestrato su dati specifici (geograficamente limitati)
• Possibili discrepanze per immobili con caratteristiche anomale
• Non considera fattori esterni (economia, politiche, eventi)

📚 RIFERIMENTI TECNICI
• Framework ML: ML.NET, scikit-learn
• Documentazione: Microsoft ML.NET docs

🔗 RISORSE
• Dataset originale disponibile su Kaggle
• Codice sorgente documentato
• Manuale utente integrato
• Log delle versioni e aggiornamenti";


🚿Esempio Con spiegazione : 
MSSubClass = "60";           // Tipo proprietà: Piani con garage



LotFrontage = "108";         // Frontale del lotto in piedi



LotArea = "13418";           // Area del lotto



OverallQual = "8";           // Qualità complessiva: alta



OverallCond = "5";           // Condizione complessiva: media


YearBuilt = "2003";          // Anno costruzione


YearRemodAdd = "2005";       // Anno ristrutturazione

MasVnrArea = "132";          // Area rivestimento in muratura

BsmtFinSF1 = "1117";         // Seminterrato finito tipo 1


BsmtFinSF2 = "0";            // Seminterrato finito tipo 2



BsmtUnfSF = "0";             // Seminterrato non finito


TotalBsmtSF = ""1117"";        // Totale area seminterrato


_1stFlrSF = "1132";          // Superficie primo piano


_2ndFlrSF = "1320";          // Superficie secondo piano


LowQualFinSF = ""0"";          // Superficie finita bassa qualità


GrLivArea = ""2452"";          // Superficie abitabile sopra terra


BsmtFullBath = ""1"";          // Bagno completo nel seminterrato


BsmtHalfBath = "0";          // Mezzo bagno nel seminterrato


FullBath = "3";              // Bagni completi


HalfBath = "1";              // Mezzi bagni


BedroomAbvGr = "4";          // Camere sopra il suolo


KitchenAbvGr = "1";          // Cucine sopra il suolo


TotRmsAbvGrd = "9";          // Totale stanze (esclusi bagni)


Fireplaces = "1";            // Camini


GarageYrBlt = "2004";        // Anno costruzione garage


GarageCars = "3";            // Capienza garage (auto)


GarageArea = "691";          // Superficie garage


WoodDeckSF = "113";          // Superficie terrazza in legno


OpenPorchSF = "32";          // Superficie veranda aperta


EnclosedPorch = "0";         // Superficie veranda chiusa


_3SsnPorch = "0";            // Veranda tre stagioni


ScreenPorch = "0";           // Veranda con zanzariere


PoolArea = "0";              // Superficie piscina


MiscVal = "0";               // Valore oggetti extra


MoSold = "2";                // Mese di vendita


YrSold = "2006";             // Anno di vendita



Creatori : Bedin Marco , Brunello Andrea , Gitaric Ivan



Link data Set : https://www.kaggle.com/code/gusthema/house-prices-prediction-using-tfdf/input?select=train.csv
