/*
               File: ProdutoWWGetFilterData
        Description: Produto WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:26.8
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class produtowwgetfilterdata : GXProcedure
   {
      public produtowwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public produtowwgetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV22DDOName = aP0_DDOName;
         this.AV20SearchTxt = aP1_SearchTxt;
         this.AV21SearchTxtTo = aP2_SearchTxtTo;
         this.AV26OptionsJson = "" ;
         this.AV29OptionsDescJson = "" ;
         this.AV31OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV26OptionsJson;
         aP4_OptionsDescJson=this.AV29OptionsDescJson;
         aP5_OptionIndexesJson=this.AV31OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV22DDOName = aP0_DDOName;
         this.AV20SearchTxt = aP1_SearchTxt;
         this.AV21SearchTxtTo = aP2_SearchTxtTo;
         this.AV26OptionsJson = "" ;
         this.AV29OptionsDescJson = "" ;
         this.AV31OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV26OptionsJson;
         aP4_OptionsDescJson=this.AV29OptionsDescJson;
         aP5_OptionIndexesJson=this.AV31OptionIndexesJson;
         return AV31OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         produtowwgetfilterdata objprodutowwgetfilterdata;
         objprodutowwgetfilterdata = new produtowwgetfilterdata();
         objprodutowwgetfilterdata.AV22DDOName = aP0_DDOName;
         objprodutowwgetfilterdata.AV20SearchTxt = aP1_SearchTxt;
         objprodutowwgetfilterdata.AV21SearchTxtTo = aP2_SearchTxtTo;
         objprodutowwgetfilterdata.AV26OptionsJson = "" ;
         objprodutowwgetfilterdata.AV29OptionsDescJson = "" ;
         objprodutowwgetfilterdata.AV31OptionIndexesJson = "" ;
         objprodutowwgetfilterdata.context.SetSubmitInitialConfig(context);
         objprodutowwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprodutowwgetfilterdata);
         aP3_OptionsJson=this.AV26OptionsJson;
         aP4_OptionsDescJson=this.AV29OptionsDescJson;
         aP5_OptionIndexesJson=this.AV31OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((produtowwgetfilterdata)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV25Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV28OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV30OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV22DDOName), "DDO_PRODUTONOME") == 0 )
         {
            /* Execute user subroutine: 'LOADPRODUTONOMEOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV26OptionsJson = AV25Options.ToJSonString(false);
         AV29OptionsDescJson = AV28OptionsDesc.ToJSonString(false);
         AV31OptionIndexesJson = AV30OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV33Session.Get("ProdutoWWGridState"), "") == 0 )
         {
            AV35GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "ProdutoWWGridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV35GridState.FromXml(AV33Session.Get("ProdutoWWGridState"), null, "WWPGridState", "FMX");
         }
         AV53GXV1 = 1;
         while ( AV53GXV1 <= AV35GridState.gxTpr_Filtervalues.Count )
         {
            AV36GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV35GridState.gxTpr_Filtervalues.Item(AV53GXV1));
            if ( StringUtil.StrCmp(AV36GridStateFilterValue.gxTpr_Name, "PRODUTODTVALIDADE") == 0 )
            {
               AV49ProdutoDtValidade = context.localUtil.CToD( AV36GridStateFilterValue.gxTpr_Value, 2);
               AV50ProdutoDtValidade_To = context.localUtil.CToD( AV36GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV36GridStateFilterValue.gxTpr_Name, "TFPRODUTOID") == 0 )
            {
               AV10TFProdutoId = (short)(NumberUtil.Val( AV36GridStateFilterValue.gxTpr_Value, "."));
               AV11TFProdutoId_To = (short)(NumberUtil.Val( AV36GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV36GridStateFilterValue.gxTpr_Name, "TFPRODUTONOME") == 0 )
            {
               AV12TFProdutoNome = AV36GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV36GridStateFilterValue.gxTpr_Name, "TFPRODUTONOME_SEL") == 0 )
            {
               AV13TFProdutoNome_Sel = AV36GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV36GridStateFilterValue.gxTpr_Name, "TFPRODUTOVALOR") == 0 )
            {
               AV16TFProdutoValor = NumberUtil.Val( AV36GridStateFilterValue.gxTpr_Value, ".");
               AV17TFProdutoValor_To = NumberUtil.Val( AV36GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV36GridStateFilterValue.gxTpr_Name, "TFPRODUTODTVALIDADE") == 0 )
            {
               AV18TFProdutoDtValidade = context.localUtil.CToD( AV36GridStateFilterValue.gxTpr_Value, 2);
               AV19TFProdutoDtValidade_To = context.localUtil.CToD( AV36GridStateFilterValue.gxTpr_Valueto, 2);
            }
            AV53GXV1 = (int)(AV53GXV1+1);
         }
         if ( AV35GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV37GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV35GridState.gxTpr_Dynamicfilters.Item(1));
            AV38DynamicFiltersSelector1 = AV37GridStateDynamicFilter.gxTpr_Selected;
            if ( StringUtil.StrCmp(AV38DynamicFiltersSelector1, "PRODUTONOME") == 0 )
            {
               AV39DynamicFiltersOperator1 = AV37GridStateDynamicFilter.gxTpr_Operator;
               AV40ProdutoNome1 = AV37GridStateDynamicFilter.gxTpr_Value;
            }
            if ( AV35GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               AV41DynamicFiltersEnabled2 = true;
               AV37GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV35GridState.gxTpr_Dynamicfilters.Item(2));
               AV42DynamicFiltersSelector2 = AV37GridStateDynamicFilter.gxTpr_Selected;
               if ( StringUtil.StrCmp(AV42DynamicFiltersSelector2, "PRODUTONOME") == 0 )
               {
                  AV43DynamicFiltersOperator2 = AV37GridStateDynamicFilter.gxTpr_Operator;
                  AV44ProdutoNome2 = AV37GridStateDynamicFilter.gxTpr_Value;
               }
               if ( AV35GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  AV45DynamicFiltersEnabled3 = true;
                  AV37GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV35GridState.gxTpr_Dynamicfilters.Item(3));
                  AV46DynamicFiltersSelector3 = AV37GridStateDynamicFilter.gxTpr_Selected;
                  if ( StringUtil.StrCmp(AV46DynamicFiltersSelector3, "PRODUTONOME") == 0 )
                  {
                     AV47DynamicFiltersOperator3 = AV37GridStateDynamicFilter.gxTpr_Operator;
                     AV48ProdutoNome3 = AV37GridStateDynamicFilter.gxTpr_Value;
                  }
               }
            }
         }
      }

      protected void S121( )
      {
         /* 'LOADPRODUTONOMEOPTIONS' Routine */
         AV12TFProdutoNome = AV20SearchTxt;
         AV13TFProdutoNome_Sel = "";
         AV55ProdutoWWDS_1_Produtodtvalidade = AV49ProdutoDtValidade;
         AV56ProdutoWWDS_2_Produtodtvalidade_to = AV50ProdutoDtValidade_To;
         AV57ProdutoWWDS_3_Dynamicfiltersselector1 = AV38DynamicFiltersSelector1;
         AV58ProdutoWWDS_4_Dynamicfiltersoperator1 = AV39DynamicFiltersOperator1;
         AV59ProdutoWWDS_5_Produtonome1 = AV40ProdutoNome1;
         AV60ProdutoWWDS_6_Dynamicfiltersenabled2 = AV41DynamicFiltersEnabled2;
         AV61ProdutoWWDS_7_Dynamicfiltersselector2 = AV42DynamicFiltersSelector2;
         AV62ProdutoWWDS_8_Dynamicfiltersoperator2 = AV43DynamicFiltersOperator2;
         AV63ProdutoWWDS_9_Produtonome2 = AV44ProdutoNome2;
         AV64ProdutoWWDS_10_Dynamicfiltersenabled3 = AV45DynamicFiltersEnabled3;
         AV65ProdutoWWDS_11_Dynamicfiltersselector3 = AV46DynamicFiltersSelector3;
         AV66ProdutoWWDS_12_Dynamicfiltersoperator3 = AV47DynamicFiltersOperator3;
         AV67ProdutoWWDS_13_Produtonome3 = AV48ProdutoNome3;
         AV68ProdutoWWDS_14_Tfprodutoid = AV10TFProdutoId;
         AV69ProdutoWWDS_15_Tfprodutoid_to = AV11TFProdutoId_To;
         AV70ProdutoWWDS_16_Tfprodutonome = AV12TFProdutoNome;
         AV71ProdutoWWDS_17_Tfprodutonome_sel = AV13TFProdutoNome_Sel;
         AV72ProdutoWWDS_18_Tfprodutovalor = AV16TFProdutoValor;
         AV73ProdutoWWDS_19_Tfprodutovalor_to = AV17TFProdutoValor_To;
         AV74ProdutoWWDS_20_Tfprodutodtvalidade = AV18TFProdutoDtValidade;
         AV75ProdutoWWDS_21_Tfprodutodtvalidade_to = AV19TFProdutoDtValidade_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV55ProdutoWWDS_1_Produtodtvalidade ,
                                              AV56ProdutoWWDS_2_Produtodtvalidade_to ,
                                              AV57ProdutoWWDS_3_Dynamicfiltersselector1 ,
                                              AV58ProdutoWWDS_4_Dynamicfiltersoperator1 ,
                                              AV59ProdutoWWDS_5_Produtonome1 ,
                                              AV60ProdutoWWDS_6_Dynamicfiltersenabled2 ,
                                              AV61ProdutoWWDS_7_Dynamicfiltersselector2 ,
                                              AV62ProdutoWWDS_8_Dynamicfiltersoperator2 ,
                                              AV63ProdutoWWDS_9_Produtonome2 ,
                                              AV64ProdutoWWDS_10_Dynamicfiltersenabled3 ,
                                              AV65ProdutoWWDS_11_Dynamicfiltersselector3 ,
                                              AV66ProdutoWWDS_12_Dynamicfiltersoperator3 ,
                                              AV67ProdutoWWDS_13_Produtonome3 ,
                                              AV68ProdutoWWDS_14_Tfprodutoid ,
                                              AV69ProdutoWWDS_15_Tfprodutoid_to ,
                                              AV71ProdutoWWDS_17_Tfprodutonome_sel ,
                                              AV70ProdutoWWDS_16_Tfprodutonome ,
                                              AV72ProdutoWWDS_18_Tfprodutovalor ,
                                              AV73ProdutoWWDS_19_Tfprodutovalor_to ,
                                              AV74ProdutoWWDS_20_Tfprodutodtvalidade ,
                                              AV75ProdutoWWDS_21_Tfprodutodtvalidade_to ,
                                              A12ProdutoDtValidade ,
                                              A9ProdutoNome ,
                                              A8ProdutoId ,
                                              A11ProdutoValor } ,
                                              new int[]{
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL
                                              }
         } ) ;
         lV59ProdutoWWDS_5_Produtonome1 = StringUtil.Concat( StringUtil.RTrim( AV59ProdutoWWDS_5_Produtonome1), "%", "");
         lV59ProdutoWWDS_5_Produtonome1 = StringUtil.Concat( StringUtil.RTrim( AV59ProdutoWWDS_5_Produtonome1), "%", "");
         lV63ProdutoWWDS_9_Produtonome2 = StringUtil.Concat( StringUtil.RTrim( AV63ProdutoWWDS_9_Produtonome2), "%", "");
         lV63ProdutoWWDS_9_Produtonome2 = StringUtil.Concat( StringUtil.RTrim( AV63ProdutoWWDS_9_Produtonome2), "%", "");
         lV67ProdutoWWDS_13_Produtonome3 = StringUtil.Concat( StringUtil.RTrim( AV67ProdutoWWDS_13_Produtonome3), "%", "");
         lV67ProdutoWWDS_13_Produtonome3 = StringUtil.Concat( StringUtil.RTrim( AV67ProdutoWWDS_13_Produtonome3), "%", "");
         lV70ProdutoWWDS_16_Tfprodutonome = StringUtil.Concat( StringUtil.RTrim( AV70ProdutoWWDS_16_Tfprodutonome), "%", "");
         /* Using cursor P000X2 */
         pr_default.execute(0, new Object[] {AV55ProdutoWWDS_1_Produtodtvalidade, AV56ProdutoWWDS_2_Produtodtvalidade_to, lV59ProdutoWWDS_5_Produtonome1, lV59ProdutoWWDS_5_Produtonome1, lV63ProdutoWWDS_9_Produtonome2, lV63ProdutoWWDS_9_Produtonome2, lV67ProdutoWWDS_13_Produtonome3, lV67ProdutoWWDS_13_Produtonome3, AV68ProdutoWWDS_14_Tfprodutoid, AV69ProdutoWWDS_15_Tfprodutoid_to, lV70ProdutoWWDS_16_Tfprodutonome, AV71ProdutoWWDS_17_Tfprodutonome_sel, AV72ProdutoWWDS_18_Tfprodutovalor, AV73ProdutoWWDS_19_Tfprodutovalor_to, AV74ProdutoWWDS_20_Tfprodutodtvalidade, AV75ProdutoWWDS_21_Tfprodutodtvalidade_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0X2 = false;
            A9ProdutoNome = P000X2_A9ProdutoNome[0];
            A11ProdutoValor = P000X2_A11ProdutoValor[0];
            A8ProdutoId = P000X2_A8ProdutoId[0];
            A12ProdutoDtValidade = P000X2_A12ProdutoDtValidade[0];
            AV32count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000X2_A9ProdutoNome[0], A9ProdutoNome) == 0 ) )
            {
               BRK0X2 = false;
               A8ProdutoId = P000X2_A8ProdutoId[0];
               AV32count = (long)(AV32count+1);
               BRK0X2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A9ProdutoNome)) )
            {
               AV24Option = A9ProdutoNome;
               AV25Options.Add(AV24Option, 0);
               AV30OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV32count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV25Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0X2 )
            {
               BRK0X2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV25Options = new GxSimpleCollection<String>();
         AV28OptionsDesc = new GxSimpleCollection<String>();
         AV30OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV33Session = context.GetSession();
         AV35GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV36GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV49ProdutoDtValidade = DateTime.MinValue;
         AV50ProdutoDtValidade_To = DateTime.MinValue;
         AV12TFProdutoNome = "";
         AV13TFProdutoNome_Sel = "";
         AV18TFProdutoDtValidade = DateTime.MinValue;
         AV19TFProdutoDtValidade_To = DateTime.MinValue;
         AV37GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV38DynamicFiltersSelector1 = "";
         AV40ProdutoNome1 = "";
         AV42DynamicFiltersSelector2 = "";
         AV44ProdutoNome2 = "";
         AV46DynamicFiltersSelector3 = "";
         AV48ProdutoNome3 = "";
         AV55ProdutoWWDS_1_Produtodtvalidade = DateTime.MinValue;
         AV56ProdutoWWDS_2_Produtodtvalidade_to = DateTime.MinValue;
         AV57ProdutoWWDS_3_Dynamicfiltersselector1 = "";
         AV59ProdutoWWDS_5_Produtonome1 = "";
         AV61ProdutoWWDS_7_Dynamicfiltersselector2 = "";
         AV63ProdutoWWDS_9_Produtonome2 = "";
         AV65ProdutoWWDS_11_Dynamicfiltersselector3 = "";
         AV67ProdutoWWDS_13_Produtonome3 = "";
         AV70ProdutoWWDS_16_Tfprodutonome = "";
         AV71ProdutoWWDS_17_Tfprodutonome_sel = "";
         AV74ProdutoWWDS_20_Tfprodutodtvalidade = DateTime.MinValue;
         AV75ProdutoWWDS_21_Tfprodutodtvalidade_to = DateTime.MinValue;
         scmdbuf = "";
         lV59ProdutoWWDS_5_Produtonome1 = "";
         lV63ProdutoWWDS_9_Produtonome2 = "";
         lV67ProdutoWWDS_13_Produtonome3 = "";
         lV70ProdutoWWDS_16_Tfprodutonome = "";
         A12ProdutoDtValidade = DateTime.MinValue;
         A9ProdutoNome = "";
         P000X2_A9ProdutoNome = new String[] {""} ;
         P000X2_A11ProdutoValor = new decimal[1] ;
         P000X2_A8ProdutoId = new short[1] ;
         P000X2_A12ProdutoDtValidade = new DateTime[] {DateTime.MinValue} ;
         AV24Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.produtowwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000X2_A9ProdutoNome, P000X2_A11ProdutoValor, P000X2_A8ProdutoId, P000X2_A12ProdutoDtValidade
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10TFProdutoId ;
      private short AV11TFProdutoId_To ;
      private short AV39DynamicFiltersOperator1 ;
      private short AV43DynamicFiltersOperator2 ;
      private short AV47DynamicFiltersOperator3 ;
      private short AV58ProdutoWWDS_4_Dynamicfiltersoperator1 ;
      private short AV62ProdutoWWDS_8_Dynamicfiltersoperator2 ;
      private short AV66ProdutoWWDS_12_Dynamicfiltersoperator3 ;
      private short AV68ProdutoWWDS_14_Tfprodutoid ;
      private short AV69ProdutoWWDS_15_Tfprodutoid_to ;
      private short A8ProdutoId ;
      private int AV53GXV1 ;
      private long AV32count ;
      private decimal AV16TFProdutoValor ;
      private decimal AV17TFProdutoValor_To ;
      private decimal AV72ProdutoWWDS_18_Tfprodutovalor ;
      private decimal AV73ProdutoWWDS_19_Tfprodutovalor_to ;
      private decimal A11ProdutoValor ;
      private String scmdbuf ;
      private DateTime AV49ProdutoDtValidade ;
      private DateTime AV50ProdutoDtValidade_To ;
      private DateTime AV18TFProdutoDtValidade ;
      private DateTime AV19TFProdutoDtValidade_To ;
      private DateTime AV55ProdutoWWDS_1_Produtodtvalidade ;
      private DateTime AV56ProdutoWWDS_2_Produtodtvalidade_to ;
      private DateTime AV74ProdutoWWDS_20_Tfprodutodtvalidade ;
      private DateTime AV75ProdutoWWDS_21_Tfprodutodtvalidade_to ;
      private DateTime A12ProdutoDtValidade ;
      private bool returnInSub ;
      private bool AV41DynamicFiltersEnabled2 ;
      private bool AV45DynamicFiltersEnabled3 ;
      private bool AV60ProdutoWWDS_6_Dynamicfiltersenabled2 ;
      private bool AV64ProdutoWWDS_10_Dynamicfiltersenabled3 ;
      private bool BRK0X2 ;
      private String AV31OptionIndexesJson ;
      private String AV26OptionsJson ;
      private String AV29OptionsDescJson ;
      private String AV22DDOName ;
      private String AV20SearchTxt ;
      private String AV21SearchTxtTo ;
      private String AV12TFProdutoNome ;
      private String AV13TFProdutoNome_Sel ;
      private String AV38DynamicFiltersSelector1 ;
      private String AV40ProdutoNome1 ;
      private String AV42DynamicFiltersSelector2 ;
      private String AV44ProdutoNome2 ;
      private String AV46DynamicFiltersSelector3 ;
      private String AV48ProdutoNome3 ;
      private String AV57ProdutoWWDS_3_Dynamicfiltersselector1 ;
      private String AV59ProdutoWWDS_5_Produtonome1 ;
      private String AV61ProdutoWWDS_7_Dynamicfiltersselector2 ;
      private String AV63ProdutoWWDS_9_Produtonome2 ;
      private String AV65ProdutoWWDS_11_Dynamicfiltersselector3 ;
      private String AV67ProdutoWWDS_13_Produtonome3 ;
      private String AV70ProdutoWWDS_16_Tfprodutonome ;
      private String AV71ProdutoWWDS_17_Tfprodutonome_sel ;
      private String lV59ProdutoWWDS_5_Produtonome1 ;
      private String lV63ProdutoWWDS_9_Produtonome2 ;
      private String lV67ProdutoWWDS_13_Produtonome3 ;
      private String lV70ProdutoWWDS_16_Tfprodutonome ;
      private String A9ProdutoNome ;
      private String AV24Option ;
      private IGxSession AV33Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000X2_A9ProdutoNome ;
      private decimal[] P000X2_A11ProdutoValor ;
      private short[] P000X2_A8ProdutoId ;
      private DateTime[] P000X2_A12ProdutoDtValidade ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV25Options ;
      private GxSimpleCollection<String> AV28OptionsDesc ;
      private GxSimpleCollection<String> AV30OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV35GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV36GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV37GridStateDynamicFilter ;
   }

   public class produtowwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000X2( IGxContext context ,
                                             DateTime AV55ProdutoWWDS_1_Produtodtvalidade ,
                                             DateTime AV56ProdutoWWDS_2_Produtodtvalidade_to ,
                                             String AV57ProdutoWWDS_3_Dynamicfiltersselector1 ,
                                             short AV58ProdutoWWDS_4_Dynamicfiltersoperator1 ,
                                             String AV59ProdutoWWDS_5_Produtonome1 ,
                                             bool AV60ProdutoWWDS_6_Dynamicfiltersenabled2 ,
                                             String AV61ProdutoWWDS_7_Dynamicfiltersselector2 ,
                                             short AV62ProdutoWWDS_8_Dynamicfiltersoperator2 ,
                                             String AV63ProdutoWWDS_9_Produtonome2 ,
                                             bool AV64ProdutoWWDS_10_Dynamicfiltersenabled3 ,
                                             String AV65ProdutoWWDS_11_Dynamicfiltersselector3 ,
                                             short AV66ProdutoWWDS_12_Dynamicfiltersoperator3 ,
                                             String AV67ProdutoWWDS_13_Produtonome3 ,
                                             short AV68ProdutoWWDS_14_Tfprodutoid ,
                                             short AV69ProdutoWWDS_15_Tfprodutoid_to ,
                                             String AV71ProdutoWWDS_17_Tfprodutonome_sel ,
                                             String AV70ProdutoWWDS_16_Tfprodutonome ,
                                             decimal AV72ProdutoWWDS_18_Tfprodutovalor ,
                                             decimal AV73ProdutoWWDS_19_Tfprodutovalor_to ,
                                             DateTime AV74ProdutoWWDS_20_Tfprodutodtvalidade ,
                                             DateTime AV75ProdutoWWDS_21_Tfprodutodtvalidade_to ,
                                             DateTime A12ProdutoDtValidade ,
                                             String A9ProdutoNome ,
                                             short A8ProdutoId ,
                                             decimal A11ProdutoValor )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [16] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [ProdutoNome], [ProdutoValor], [ProdutoId], [ProdutoDtValidade] FROM [Produto]";
         if ( ! (DateTime.MinValue==AV55ProdutoWWDS_1_Produtodtvalidade) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] >= @AV55ProdutoWWDS_1_Produtodtvalidade)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] >= @AV55ProdutoWWDS_1_Produtodtvalidade)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV56ProdutoWWDS_2_Produtodtvalidade_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] <= @AV56ProdutoWWDS_2_Produtodtvalidade_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] <= @AV56ProdutoWWDS_2_Produtodtvalidade_to)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV57ProdutoWWDS_3_Dynamicfiltersselector1, "PRODUTONOME") == 0 ) && ( AV58ProdutoWWDS_4_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59ProdutoWWDS_5_Produtonome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV59ProdutoWWDS_5_Produtonome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV59ProdutoWWDS_5_Produtonome1)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV57ProdutoWWDS_3_Dynamicfiltersselector1, "PRODUTONOME") == 0 ) && ( AV58ProdutoWWDS_4_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59ProdutoWWDS_5_Produtonome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV59ProdutoWWDS_5_Produtonome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV59ProdutoWWDS_5_Produtonome1)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( AV60ProdutoWWDS_6_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV61ProdutoWWDS_7_Dynamicfiltersselector2, "PRODUTONOME") == 0 ) && ( AV62ProdutoWWDS_8_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63ProdutoWWDS_9_Produtonome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV63ProdutoWWDS_9_Produtonome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV63ProdutoWWDS_9_Produtonome2)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( AV60ProdutoWWDS_6_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV61ProdutoWWDS_7_Dynamicfiltersselector2, "PRODUTONOME") == 0 ) && ( AV62ProdutoWWDS_8_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63ProdutoWWDS_9_Produtonome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV63ProdutoWWDS_9_Produtonome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV63ProdutoWWDS_9_Produtonome2)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( AV64ProdutoWWDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV65ProdutoWWDS_11_Dynamicfiltersselector3, "PRODUTONOME") == 0 ) && ( AV66ProdutoWWDS_12_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67ProdutoWWDS_13_Produtonome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV67ProdutoWWDS_13_Produtonome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV67ProdutoWWDS_13_Produtonome3)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( AV64ProdutoWWDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV65ProdutoWWDS_11_Dynamicfiltersselector3, "PRODUTONOME") == 0 ) && ( AV66ProdutoWWDS_12_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67ProdutoWWDS_13_Produtonome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV67ProdutoWWDS_13_Produtonome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV67ProdutoWWDS_13_Produtonome3)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! (0==AV68ProdutoWWDS_14_Tfprodutoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoId] >= @AV68ProdutoWWDS_14_Tfprodutoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoId] >= @AV68ProdutoWWDS_14_Tfprodutoid)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( ! (0==AV69ProdutoWWDS_15_Tfprodutoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoId] <= @AV69ProdutoWWDS_15_Tfprodutoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoId] <= @AV69ProdutoWWDS_15_Tfprodutoid_to)";
            }
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV71ProdutoWWDS_17_Tfprodutonome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70ProdutoWWDS_16_Tfprodutonome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV70ProdutoWWDS_16_Tfprodutonome)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV70ProdutoWWDS_16_Tfprodutonome)";
            }
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71ProdutoWWDS_17_Tfprodutonome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] = @AV71ProdutoWWDS_17_Tfprodutonome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] = @AV71ProdutoWWDS_17_Tfprodutonome_sel)";
            }
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV72ProdutoWWDS_18_Tfprodutovalor) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoValor] >= @AV72ProdutoWWDS_18_Tfprodutovalor)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoValor] >= @AV72ProdutoWWDS_18_Tfprodutovalor)";
            }
         }
         else
         {
            GXv_int1[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV73ProdutoWWDS_19_Tfprodutovalor_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoValor] <= @AV73ProdutoWWDS_19_Tfprodutovalor_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoValor] <= @AV73ProdutoWWDS_19_Tfprodutovalor_to)";
            }
         }
         else
         {
            GXv_int1[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV74ProdutoWWDS_20_Tfprodutodtvalidade) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] >= @AV74ProdutoWWDS_20_Tfprodutodtvalidade)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] >= @AV74ProdutoWWDS_20_Tfprodutodtvalidade)";
            }
         }
         else
         {
            GXv_int1[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV75ProdutoWWDS_21_Tfprodutodtvalidade_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] <= @AV75ProdutoWWDS_21_Tfprodutodtvalidade_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] <= @AV75ProdutoWWDS_21_Tfprodutodtvalidade_to)";
            }
         }
         else
         {
            GXv_int1[15] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [ProdutoNome]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000X2(context, (DateTime)dynConstraints[0] , (DateTime)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (bool)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (decimal)dynConstraints[17] , (decimal)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (DateTime)dynConstraints[21] , (String)dynConstraints[22] , (short)dynConstraints[23] , (decimal)dynConstraints[24] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000X2 ;
          prmP000X2 = new Object[] {
          new Object[] {"@AV55ProdutoWWDS_1_Produtodtvalidade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV56ProdutoWWDS_2_Produtodtvalidade_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV59ProdutoWWDS_5_Produtonome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV59ProdutoWWDS_5_Produtonome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV63ProdutoWWDS_9_Produtonome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV63ProdutoWWDS_9_Produtonome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV67ProdutoWWDS_13_Produtonome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV67ProdutoWWDS_13_Produtonome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV68ProdutoWWDS_14_Tfprodutoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV69ProdutoWWDS_15_Tfprodutoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV70ProdutoWWDS_16_Tfprodutonome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV71ProdutoWWDS_17_Tfprodutonome_sel",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV72ProdutoWWDS_18_Tfprodutovalor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV73ProdutoWWDS_19_Tfprodutovalor_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV74ProdutoWWDS_20_Tfprodutodtvalidade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV75ProdutoWWDS_21_Tfprodutodtvalidade_to",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000X2,100, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[24]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[25]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[28]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[29]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.produtowwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class produtowwgetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("produtowwgetfilterdata") )
          {
             return  ;
          }
          produtowwgetfilterdata worker = new produtowwgetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
