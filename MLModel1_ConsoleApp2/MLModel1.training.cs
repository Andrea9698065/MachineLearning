﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.LightGbm;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace MLModel1_ConsoleApp2
{
    public partial class MLModel1
    {
        public const string RetrainFilePath =  @"C:\Users\andre\Downloads\train_numeric.csv";
        public const char RetrainSeparatorChar = ',';
        public const bool RetrainHasHeader =  true;

         /// <summary>
        /// Train a new model with the provided dataset.
        /// </summary>
        /// <param name="outputModelPath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet"</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        public static void Train(string outputModelPath, string inputDataFilePath = RetrainFilePath, char separatorChar = RetrainSeparatorChar, bool hasHeader = RetrainHasHeader)
        {
            var mlContext = new MLContext();

            var data = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader);
            var model = RetrainModel(mlContext, data);
            SaveModel(mlContext, model, data, outputModelPath);
        }

        /// <summary>
        /// Load an IDataView from a file path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        /// <returns>IDataView with loaded training data.</returns>
        public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader)
        {
            return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader);
        }



        /// <summary>
        /// Save a model at the specified path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="model">Model to save.</param>
        /// <param name="data">IDataView used to train the model.</param>
        /// <param name="modelSavePath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet.</param>
        public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
        {
            // Pull the data schema from the IDataView used for training the model
            DataViewSchema dataViewSchema = data.Schema;

            using (var fs = File.Create(modelSavePath))
            {
                mlContext.Model.Save(model, dataViewSchema, fs);
            }
        }


        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }


        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"Id", @"Id"),new InputOutputColumnPair(@"MSSubClass", @"MSSubClass"),new InputOutputColumnPair(@"LotFrontage", @"LotFrontage"),new InputOutputColumnPair(@"LotArea", @"LotArea"),new InputOutputColumnPair(@"OverallQual", @"OverallQual"),new InputOutputColumnPair(@"OverallCond", @"OverallCond"),new InputOutputColumnPair(@"YearBuilt", @"YearBuilt"),new InputOutputColumnPair(@"YearRemodAdd", @"YearRemodAdd"),new InputOutputColumnPair(@"MasVnrArea", @"MasVnrArea"),new InputOutputColumnPair(@"BsmtFinSF1", @"BsmtFinSF1"),new InputOutputColumnPair(@"BsmtFinSF2", @"BsmtFinSF2"),new InputOutputColumnPair(@"BsmtUnfSF", @"BsmtUnfSF"),new InputOutputColumnPair(@"TotalBsmtSF", @"TotalBsmtSF"),new InputOutputColumnPair(@"1stFlrSF", @"1stFlrSF"),new InputOutputColumnPair(@"2ndFlrSF", @"2ndFlrSF"),new InputOutputColumnPair(@"LowQualFinSF", @"LowQualFinSF"),new InputOutputColumnPair(@"GrLivArea", @"GrLivArea"),new InputOutputColumnPair(@"BsmtFullBath", @"BsmtFullBath"),new InputOutputColumnPair(@"BsmtHalfBath", @"BsmtHalfBath"),new InputOutputColumnPair(@"FullBath", @"FullBath"),new InputOutputColumnPair(@"HalfBath", @"HalfBath"),new InputOutputColumnPair(@"BedroomAbvGr", @"BedroomAbvGr"),new InputOutputColumnPair(@"KitchenAbvGr", @"KitchenAbvGr"),new InputOutputColumnPair(@"TotRmsAbvGrd", @"TotRmsAbvGrd"),new InputOutputColumnPair(@"Fireplaces", @"Fireplaces"),new InputOutputColumnPair(@"GarageYrBlt", @"GarageYrBlt"),new InputOutputColumnPair(@"GarageCars", @"GarageCars"),new InputOutputColumnPair(@"GarageArea", @"GarageArea"),new InputOutputColumnPair(@"WoodDeckSF", @"WoodDeckSF"),new InputOutputColumnPair(@"OpenPorchSF", @"OpenPorchSF"),new InputOutputColumnPair(@"EnclosedPorch", @"EnclosedPorch"),new InputOutputColumnPair(@"3SsnPorch", @"3SsnPorch"),new InputOutputColumnPair(@"ScreenPorch", @"ScreenPorch"),new InputOutputColumnPair(@"PoolArea", @"PoolArea"),new InputOutputColumnPair(@"MiscVal", @"MiscVal"),new InputOutputColumnPair(@"MoSold", @"MoSold"),new InputOutputColumnPair(@"YrSold", @"YrSold")})      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Id",@"MSSubClass",@"LotFrontage",@"LotArea",@"OverallQual",@"OverallCond",@"YearBuilt",@"YearRemodAdd",@"MasVnrArea",@"BsmtFinSF1",@"BsmtFinSF2",@"BsmtUnfSF",@"TotalBsmtSF",@"1stFlrSF",@"2ndFlrSF",@"LowQualFinSF",@"GrLivArea",@"BsmtFullBath",@"BsmtHalfBath",@"FullBath",@"HalfBath",@"BedroomAbvGr",@"KitchenAbvGr",@"TotRmsAbvGrd",@"Fireplaces",@"GarageYrBlt",@"GarageCars",@"GarageArea",@"WoodDeckSF",@"OpenPorchSF",@"EnclosedPorch",@"3SsnPorch",@"ScreenPorch",@"PoolArea",@"MiscVal",@"MoSold",@"YrSold"}))      
                                    .Append(mlContext.Regression.Trainers.LightGbm(new LightGbmRegressionTrainer.Options(){NumberOfLeaves=1298,NumberOfIterations=2440,MinimumExampleCountPerLeaf=22,LearningRate=0.306169915036931,LabelColumnName=@"SalePrice",FeatureColumnName=@"Features",ExampleWeightColumnName=null,Booster=new GradientBooster.Options(){SubsampleFraction=0.00738366835602812,FeatureFraction=0.905547733980201,L1Regularization=3.95542967656147E-09,L2Regularization=0.280823632445514},MaximumBinCountPerFeature=1023}));

            return pipeline;
        }
    }
 }
