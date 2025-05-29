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
