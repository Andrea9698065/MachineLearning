@"🏠 SISTEMA DI VALUTAZIONE IMMOBILIARE CON MACHINE LEARNING
📌 OBIETTIVO
Creare un modello di Machine Learning supervisionato che preveda il prezzo degli immobili da input utente.
Sviluppare un modello di supervised learning in Python (usando scikit-learn, pandas o simili) oppure C# machine learning platform,
capace di apprendere da un dataset reale e restituire previsioni credibili su nuovi input.
Scegli un dataset da una fonte affidabile (Kaggle, UCI, OpenML) e descrivilo brevemente.
Pulisci e prepara i dati (gestione dei null, normalizzazione, train-test split).
Applica almeno un algoritmo supervisionato (es. Decision Tree, KNN, SVM, Logistic Regression).
Valuta le prestazioni del modello con metriche appropriate.
Testa il modello con almeno tre input inventati ma realistici.
Concludi con una breve riflessione su efficacia e limiti del lavoro.
Il link alla repository GIT con dataset e codice del machine learning, inoltre consegnare una presentazione che spieghi i procedimenti e l'algoritmo di machine learning scelto
                        
📊 DATASET
• Fonte: Kaggle - House Prices Dataset
• Contenuto: Informazioni dettagliate su proprietà immobiliari
• Variabili: Superficie, numero stanze, anno costruzione, qualità, condizioni, garage, ecc.
• Dimensioni: Migliaia di record con 36+ caratteristiche

📐 PREPROCESSING DEI DATI
• Pulizia dati: Rimozione valori nulli e anomali
• Split Dataset: 80% training / 20% testing

🧠 MODELLO UTILIZZATO
• Algoritmo Principale: Decision Tree Regressor (scikit-learn)
• Alternative Valutate: K-Nearest Neighbors, Linear Regression, Random Forest
• Ottimizzazione: Grid Search per iperparametri
• Validazione: Cross-validation k-fold



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
• Best Practices: Machine Learning engineering principles
• Metodologia: CRISP-DM (Cross Industry Standard Process for Data Mining)

🔗 RISORSE
• Dataset originale disponibile su Kaggle
• Codice sorgente documentato
• Manuale utente integrato
• Log delle versioni e aggiornamenti";

Creatori : Bedin Marco , Brunello Andrea , Gitaric Ivan
Link data Set : https://www.kaggle.com/code/gusthema/house-prices-prediction-using-tfdf/input?select=train.csv
