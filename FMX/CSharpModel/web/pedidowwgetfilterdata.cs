/*
               File: PedidoWWGetFilterData
        Description: Pedido WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:26.35
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
   public class pedidowwgetfilterdata : GXProcedure
   {
      public pedidowwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pedidowwgetfilterdata( IGxContext context )
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
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
         return AV34OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         pedidowwgetfilterdata objpedidowwgetfilterdata;
         objpedidowwgetfilterdata = new pedidowwgetfilterdata();
         objpedidowwgetfilterdata.AV25DDOName = aP0_DDOName;
         objpedidowwgetfilterdata.AV23SearchTxt = aP1_SearchTxt;
         objpedidowwgetfilterdata.AV24SearchTxtTo = aP2_SearchTxtTo;
         objpedidowwgetfilterdata.AV29OptionsJson = "" ;
         objpedidowwgetfilterdata.AV32OptionsDescJson = "" ;
         objpedidowwgetfilterdata.AV34OptionIndexesJson = "" ;
         objpedidowwgetfilterdata.context.SetSubmitInitialConfig(context);
         objpedidowwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpedidowwgetfilterdata);
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pedidowwgetfilterdata)stateInfo).executePrivate();
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
         AV28Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV31OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV33OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_PESSOANOME") == 0 )
         {
            /* Execute user subroutine: 'LOADPESSOANOMEOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV29OptionsJson = AV28Options.ToJSonString(false);
         AV32OptionsDescJson = AV31OptionsDesc.ToJSonString(false);
         AV34OptionIndexesJson = AV33OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV36Session.Get("PedidoWWGridState"), "") == 0 )
         {
            AV38GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "PedidoWWGridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV38GridState.FromXml(AV36Session.Get("PedidoWWGridState"), null, "WWPGridState", "FMX");
         }
         AV52GXV1 = 1;
         while ( AV52GXV1 <= AV38GridState.gxTpr_Filtervalues.Count )
         {
            AV39GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV38GridState.gxTpr_Filtervalues.Item(AV52GXV1));
            if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "PESSOANOME") == 0 )
            {
               AV42PessoaNome = AV39GridStateFilterValue.gxTpr_Value;
               AV41PessoaNomeOperator = AV39GridStateFilterValue.gxTpr_Operator;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "PEDIDODT") == 0 )
            {
               AV43PedidoDt = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Value, 2);
               AV44PedidoDt_To = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "PEDIDODTENTREGA") == 0 )
            {
               AV45PedidoDtEntrega = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Value, 2);
               AV46PedidoDtEntrega_To = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "PEDIDOSTATUS") == 0 )
            {
               AV47PedidoStatus = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPEDIDOID") == 0 )
            {
               AV10TFPedidoId = (short)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV11TFPedidoId_To = (short)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOANOME") == 0 )
            {
               AV12TFPessoaNome = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOANOME_SEL") == 0 )
            {
               AV13TFPessoaNome_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPEDIDODT") == 0 )
            {
               AV14TFPedidoDt = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Value, 2);
               AV15TFPedidoDt_To = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPEDIDOSTATUS_SEL") == 0 )
            {
               AV16TFPedidoStatus_SelsJson = AV39GridStateFilterValue.gxTpr_Value;
               AV17TFPedidoStatus_Sels.FromJSonString(AV16TFPedidoStatus_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPEDIDODTENTREGA") == 0 )
            {
               AV18TFPedidoDtEntrega = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Value, 2);
               AV19TFPedidoDtEntrega_To = context.localUtil.CToD( AV39GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPEDIDORETIRADA_SEL") == 0 )
            {
               AV20TFPedidoRetirada_Sel = (short)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPEDIDOTOTAL") == 0 )
            {
               AV21TFPedidoTotal = NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, ".");
               AV22TFPedidoTotal_To = NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, ".");
            }
            AV52GXV1 = (int)(AV52GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADPESSOANOMEOPTIONS' Routine */
         AV12TFPessoaNome = AV23SearchTxt;
         AV13TFPessoaNome_Sel = "";
         AV54PedidoWWDS_1_Pessoanome = AV42PessoaNome;
         AV55PedidoWWDS_2_Pedidodt = AV43PedidoDt;
         AV56PedidoWWDS_3_Pedidodt_to = AV44PedidoDt_To;
         AV57PedidoWWDS_4_Pedidodtentrega = AV45PedidoDtEntrega;
         AV58PedidoWWDS_5_Pedidodtentrega_to = AV46PedidoDtEntrega_To;
         AV59PedidoWWDS_6_Pedidostatus = AV47PedidoStatus;
         AV60PedidoWWDS_7_Tfpedidoid = AV10TFPedidoId;
         AV61PedidoWWDS_8_Tfpedidoid_to = AV11TFPedidoId_To;
         AV62PedidoWWDS_9_Tfpessoanome = AV12TFPessoaNome;
         AV63PedidoWWDS_10_Tfpessoanome_sel = AV13TFPessoaNome_Sel;
         AV64PedidoWWDS_11_Tfpedidodt = AV14TFPedidoDt;
         AV65PedidoWWDS_12_Tfpedidodt_to = AV15TFPedidoDt_To;
         AV66PedidoWWDS_13_Tfpedidostatus_sels = AV17TFPedidoStatus_Sels;
         AV67PedidoWWDS_14_Tfpedidodtentrega = AV18TFPedidoDtEntrega;
         AV68PedidoWWDS_15_Tfpedidodtentrega_to = AV19TFPedidoDtEntrega_To;
         AV69PedidoWWDS_16_Tfpedidoretirada_sel = AV20TFPedidoRetirada_Sel;
         AV70PedidoWWDS_17_Tfpedidototal = AV21TFPedidoTotal;
         AV71PedidoWWDS_18_Tfpedidototal_to = AV22TFPedidoTotal_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A34PedidoStatus ,
                                              AV66PedidoWWDS_13_Tfpedidostatus_sels ,
                                              AV41PessoaNomeOperator ,
                                              AV54PedidoWWDS_1_Pessoanome ,
                                              AV55PedidoWWDS_2_Pedidodt ,
                                              AV56PedidoWWDS_3_Pedidodt_to ,
                                              AV57PedidoWWDS_4_Pedidodtentrega ,
                                              AV58PedidoWWDS_5_Pedidodtentrega_to ,
                                              AV59PedidoWWDS_6_Pedidostatus ,
                                              AV60PedidoWWDS_7_Tfpedidoid ,
                                              AV61PedidoWWDS_8_Tfpedidoid_to ,
                                              AV63PedidoWWDS_10_Tfpessoanome_sel ,
                                              AV62PedidoWWDS_9_Tfpessoanome ,
                                              AV64PedidoWWDS_11_Tfpedidodt ,
                                              AV65PedidoWWDS_12_Tfpedidodt_to ,
                                              AV66PedidoWWDS_13_Tfpedidostatus_sels.Count ,
                                              AV67PedidoWWDS_14_Tfpedidodtentrega ,
                                              AV68PedidoWWDS_15_Tfpedidodtentrega_to ,
                                              AV69PedidoWWDS_16_Tfpedidoretirada_sel ,
                                              AV70PedidoWWDS_17_Tfpedidototal ,
                                              AV71PedidoWWDS_18_Tfpedidototal_to ,
                                              A2PessoaNome ,
                                              A33PedidoDt ,
                                              A35PedidoDtEntrega ,
                                              A32PedidoId ,
                                              A36PedidoRetirada ,
                                              A37PedidoTotal } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL
                                              }
         } ) ;
         lV54PedidoWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV54PedidoWWDS_1_Pessoanome), "%", "");
         lV62PedidoWWDS_9_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV62PedidoWWDS_9_Tfpessoanome), "%", "");
         /* Using cursor P00122 */
         pr_default.execute(0, new Object[] {lV54PedidoWWDS_1_Pessoanome, AV55PedidoWWDS_2_Pedidodt, AV56PedidoWWDS_3_Pedidodt_to, AV57PedidoWWDS_4_Pedidodtentrega, AV58PedidoWWDS_5_Pedidodtentrega_to, AV59PedidoWWDS_6_Pedidostatus, AV60PedidoWWDS_7_Tfpedidoid, AV61PedidoWWDS_8_Tfpedidoid_to, lV62PedidoWWDS_9_Tfpessoanome, AV63PedidoWWDS_10_Tfpessoanome_sel, AV64PedidoWWDS_11_Tfpedidodt, AV65PedidoWWDS_12_Tfpedidodt_to, AV67PedidoWWDS_14_Tfpedidodtentrega, AV68PedidoWWDS_15_Tfpedidodtentrega_to, AV70PedidoWWDS_17_Tfpedidototal, AV71PedidoWWDS_18_Tfpedidototal_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK122 = false;
            A1PessoaId = P00122_A1PessoaId[0];
            A2PessoaNome = P00122_A2PessoaNome[0];
            A37PedidoTotal = P00122_A37PedidoTotal[0];
            A36PedidoRetirada = P00122_A36PedidoRetirada[0];
            A32PedidoId = P00122_A32PedidoId[0];
            A34PedidoStatus = P00122_A34PedidoStatus[0];
            A35PedidoDtEntrega = P00122_A35PedidoDtEntrega[0];
            A33PedidoDt = P00122_A33PedidoDt[0];
            A2PessoaNome = P00122_A2PessoaNome[0];
            AV35count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00122_A2PessoaNome[0], A2PessoaNome) == 0 ) )
            {
               BRK122 = false;
               A1PessoaId = P00122_A1PessoaId[0];
               A32PedidoId = P00122_A32PedidoId[0];
               AV35count = (long)(AV35count+1);
               BRK122 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A2PessoaNome)) )
            {
               AV27Option = A2PessoaNome;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK122 )
            {
               BRK122 = true;
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
         AV28Options = new GxSimpleCollection<String>();
         AV31OptionsDesc = new GxSimpleCollection<String>();
         AV33OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV36Session = context.GetSession();
         AV38GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV39GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV42PessoaNome = "";
         AV43PedidoDt = DateTime.MinValue;
         AV44PedidoDt_To = DateTime.MinValue;
         AV45PedidoDtEntrega = DateTime.MinValue;
         AV46PedidoDtEntrega_To = DateTime.MinValue;
         AV47PedidoStatus = "";
         AV12TFPessoaNome = "";
         AV13TFPessoaNome_Sel = "";
         AV14TFPedidoDt = DateTime.MinValue;
         AV15TFPedidoDt_To = DateTime.MinValue;
         AV16TFPedidoStatus_SelsJson = "";
         AV17TFPedidoStatus_Sels = new GxSimpleCollection<String>();
         AV18TFPedidoDtEntrega = DateTime.MinValue;
         AV19TFPedidoDtEntrega_To = DateTime.MinValue;
         AV54PedidoWWDS_1_Pessoanome = "";
         AV55PedidoWWDS_2_Pedidodt = DateTime.MinValue;
         AV56PedidoWWDS_3_Pedidodt_to = DateTime.MinValue;
         AV57PedidoWWDS_4_Pedidodtentrega = DateTime.MinValue;
         AV58PedidoWWDS_5_Pedidodtentrega_to = DateTime.MinValue;
         AV59PedidoWWDS_6_Pedidostatus = "";
         AV62PedidoWWDS_9_Tfpessoanome = "";
         AV63PedidoWWDS_10_Tfpessoanome_sel = "";
         AV64PedidoWWDS_11_Tfpedidodt = DateTime.MinValue;
         AV65PedidoWWDS_12_Tfpedidodt_to = DateTime.MinValue;
         AV66PedidoWWDS_13_Tfpedidostatus_sels = new GxSimpleCollection<String>();
         AV67PedidoWWDS_14_Tfpedidodtentrega = DateTime.MinValue;
         AV68PedidoWWDS_15_Tfpedidodtentrega_to = DateTime.MinValue;
         scmdbuf = "";
         lV54PedidoWWDS_1_Pessoanome = "";
         lV62PedidoWWDS_9_Tfpessoanome = "";
         A34PedidoStatus = "";
         A2PessoaNome = "";
         A33PedidoDt = DateTime.MinValue;
         A35PedidoDtEntrega = DateTime.MinValue;
         P00122_A1PessoaId = new short[1] ;
         P00122_A2PessoaNome = new String[] {""} ;
         P00122_A37PedidoTotal = new decimal[1] ;
         P00122_A36PedidoRetirada = new bool[] {false} ;
         P00122_A32PedidoId = new short[1] ;
         P00122_A34PedidoStatus = new String[] {""} ;
         P00122_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         P00122_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         AV27Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pedidowwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00122_A1PessoaId, P00122_A2PessoaNome, P00122_A37PedidoTotal, P00122_A36PedidoRetirada, P00122_A32PedidoId, P00122_A34PedidoStatus, P00122_A35PedidoDtEntrega, P00122_A33PedidoDt
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV41PessoaNomeOperator ;
      private short AV10TFPedidoId ;
      private short AV11TFPedidoId_To ;
      private short AV20TFPedidoRetirada_Sel ;
      private short AV60PedidoWWDS_7_Tfpedidoid ;
      private short AV61PedidoWWDS_8_Tfpedidoid_to ;
      private short AV69PedidoWWDS_16_Tfpedidoretirada_sel ;
      private short A32PedidoId ;
      private short A1PessoaId ;
      private int AV52GXV1 ;
      private int AV66PedidoWWDS_13_Tfpedidostatus_sels_Count ;
      private long AV35count ;
      private decimal AV21TFPedidoTotal ;
      private decimal AV22TFPedidoTotal_To ;
      private decimal AV70PedidoWWDS_17_Tfpedidototal ;
      private decimal AV71PedidoWWDS_18_Tfpedidototal_to ;
      private decimal A37PedidoTotal ;
      private String scmdbuf ;
      private DateTime AV43PedidoDt ;
      private DateTime AV44PedidoDt_To ;
      private DateTime AV45PedidoDtEntrega ;
      private DateTime AV46PedidoDtEntrega_To ;
      private DateTime AV14TFPedidoDt ;
      private DateTime AV15TFPedidoDt_To ;
      private DateTime AV18TFPedidoDtEntrega ;
      private DateTime AV19TFPedidoDtEntrega_To ;
      private DateTime AV55PedidoWWDS_2_Pedidodt ;
      private DateTime AV56PedidoWWDS_3_Pedidodt_to ;
      private DateTime AV57PedidoWWDS_4_Pedidodtentrega ;
      private DateTime AV58PedidoWWDS_5_Pedidodtentrega_to ;
      private DateTime AV64PedidoWWDS_11_Tfpedidodt ;
      private DateTime AV65PedidoWWDS_12_Tfpedidodt_to ;
      private DateTime AV67PedidoWWDS_14_Tfpedidodtentrega ;
      private DateTime AV68PedidoWWDS_15_Tfpedidodtentrega_to ;
      private DateTime A33PedidoDt ;
      private DateTime A35PedidoDtEntrega ;
      private bool returnInSub ;
      private bool A36PedidoRetirada ;
      private bool BRK122 ;
      private String AV34OptionIndexesJson ;
      private String AV29OptionsJson ;
      private String AV32OptionsDescJson ;
      private String AV16TFPedidoStatus_SelsJson ;
      private String AV25DDOName ;
      private String AV23SearchTxt ;
      private String AV24SearchTxtTo ;
      private String AV42PessoaNome ;
      private String AV47PedidoStatus ;
      private String AV12TFPessoaNome ;
      private String AV13TFPessoaNome_Sel ;
      private String AV54PedidoWWDS_1_Pessoanome ;
      private String AV59PedidoWWDS_6_Pedidostatus ;
      private String AV62PedidoWWDS_9_Tfpessoanome ;
      private String AV63PedidoWWDS_10_Tfpessoanome_sel ;
      private String lV54PedidoWWDS_1_Pessoanome ;
      private String lV62PedidoWWDS_9_Tfpessoanome ;
      private String A34PedidoStatus ;
      private String A2PessoaNome ;
      private String AV27Option ;
      private IGxSession AV36Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00122_A1PessoaId ;
      private String[] P00122_A2PessoaNome ;
      private decimal[] P00122_A37PedidoTotal ;
      private bool[] P00122_A36PedidoRetirada ;
      private short[] P00122_A32PedidoId ;
      private String[] P00122_A34PedidoStatus ;
      private DateTime[] P00122_A35PedidoDtEntrega ;
      private DateTime[] P00122_A33PedidoDt ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV28Options ;
      private GxSimpleCollection<String> AV31OptionsDesc ;
      private GxSimpleCollection<String> AV33OptionIndexes ;
      private GxSimpleCollection<String> AV17TFPedidoStatus_Sels ;
      private GxSimpleCollection<String> AV66PedidoWWDS_13_Tfpedidostatus_sels ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV38GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV39GridStateFilterValue ;
   }

   public class pedidowwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00122( IGxContext context ,
                                             String A34PedidoStatus ,
                                             GxSimpleCollection<String> AV66PedidoWWDS_13_Tfpedidostatus_sels ,
                                             short AV41PessoaNomeOperator ,
                                             String AV54PedidoWWDS_1_Pessoanome ,
                                             DateTime AV55PedidoWWDS_2_Pedidodt ,
                                             DateTime AV56PedidoWWDS_3_Pedidodt_to ,
                                             DateTime AV57PedidoWWDS_4_Pedidodtentrega ,
                                             DateTime AV58PedidoWWDS_5_Pedidodtentrega_to ,
                                             String AV59PedidoWWDS_6_Pedidostatus ,
                                             short AV60PedidoWWDS_7_Tfpedidoid ,
                                             short AV61PedidoWWDS_8_Tfpedidoid_to ,
                                             String AV63PedidoWWDS_10_Tfpessoanome_sel ,
                                             String AV62PedidoWWDS_9_Tfpessoanome ,
                                             DateTime AV64PedidoWWDS_11_Tfpedidodt ,
                                             DateTime AV65PedidoWWDS_12_Tfpedidodt_to ,
                                             int AV66PedidoWWDS_13_Tfpedidostatus_sels_Count ,
                                             DateTime AV67PedidoWWDS_14_Tfpedidodtentrega ,
                                             DateTime AV68PedidoWWDS_15_Tfpedidodtentrega_to ,
                                             short AV69PedidoWWDS_16_Tfpedidoretirada_sel ,
                                             decimal AV70PedidoWWDS_17_Tfpedidototal ,
                                             decimal AV71PedidoWWDS_18_Tfpedidototal_to ,
                                             String A2PessoaNome ,
                                             DateTime A33PedidoDt ,
                                             DateTime A35PedidoDtEntrega ,
                                             short A32PedidoId ,
                                             bool A36PedidoRetirada ,
                                             decimal A37PedidoTotal )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [16] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T1.[PessoaId], T2.[PessoaNome], T1.[PedidoTotal], T1.[PedidoRetirada], T1.[PedidoId], T1.[PedidoStatus], T1.[PedidoDtEntrega], T1.[PedidoDt] FROM ([Pedido] T1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = T1.[PessoaId])";
         if ( ( AV41PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54PedidoWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like '%' + @lV54PedidoWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like '%' + @lV54PedidoWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV55PedidoWWDS_2_Pedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV55PedidoWWDS_2_Pedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV55PedidoWWDS_2_Pedidodt)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV56PedidoWWDS_3_Pedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV56PedidoWWDS_3_Pedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV56PedidoWWDS_3_Pedidodt_to)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV57PedidoWWDS_4_Pedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV57PedidoWWDS_4_Pedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV57PedidoWWDS_4_Pedidodtentrega)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV58PedidoWWDS_5_Pedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV58PedidoWWDS_5_Pedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV58PedidoWWDS_5_Pedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59PedidoWWDS_6_Pedidostatus)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoStatus] = @AV59PedidoWWDS_6_Pedidostatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoStatus] = @AV59PedidoWWDS_6_Pedidostatus)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV60PedidoWWDS_7_Tfpedidoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] >= @AV60PedidoWWDS_7_Tfpedidoid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] >= @AV60PedidoWWDS_7_Tfpedidoid)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( ! (0==AV61PedidoWWDS_8_Tfpedidoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] <= @AV61PedidoWWDS_8_Tfpedidoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] <= @AV61PedidoWWDS_8_Tfpedidoid_to)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63PedidoWWDS_10_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62PedidoWWDS_9_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like @lV62PedidoWWDS_9_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like @lV62PedidoWWDS_9_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63PedidoWWDS_10_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] = @AV63PedidoWWDS_10_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] = @AV63PedidoWWDS_10_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV64PedidoWWDS_11_Tfpedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV64PedidoWWDS_11_Tfpedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV64PedidoWWDS_11_Tfpedidodt)";
            }
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV65PedidoWWDS_12_Tfpedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV65PedidoWWDS_12_Tfpedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV65PedidoWWDS_12_Tfpedidodt_to)";
            }
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( AV66PedidoWWDS_13_Tfpedidostatus_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV66PedidoWWDS_13_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV66PedidoWWDS_13_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV67PedidoWWDS_14_Tfpedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV67PedidoWWDS_14_Tfpedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV67PedidoWWDS_14_Tfpedidodtentrega)";
            }
         }
         else
         {
            GXv_int1[12] = 1;
         }
         if ( ! (DateTime.MinValue==AV68PedidoWWDS_15_Tfpedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV68PedidoWWDS_15_Tfpedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV68PedidoWWDS_15_Tfpedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int1[13] = 1;
         }
         if ( AV69PedidoWWDS_16_Tfpedidoretirada_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoRetirada] = 1)";
            }
         }
         if ( AV69PedidoWWDS_16_Tfpedidoretirada_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoRetirada] = 0)";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV70PedidoWWDS_17_Tfpedidototal) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] >= @AV70PedidoWWDS_17_Tfpedidototal)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] >= @AV70PedidoWWDS_17_Tfpedidototal)";
            }
         }
         else
         {
            GXv_int1[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV71PedidoWWDS_18_Tfpedidototal_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] <= @AV71PedidoWWDS_18_Tfpedidototal_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] <= @AV71PedidoWWDS_18_Tfpedidototal_to)";
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
         scmdbuf = scmdbuf + " ORDER BY T2.[PessoaNome]";
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
                     return conditional_P00122(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (DateTime)dynConstraints[17] , (short)dynConstraints[18] , (decimal)dynConstraints[19] , (decimal)dynConstraints[20] , (String)dynConstraints[21] , (DateTime)dynConstraints[22] , (DateTime)dynConstraints[23] , (short)dynConstraints[24] , (bool)dynConstraints[25] , (decimal)dynConstraints[26] );
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
          Object[] prmP00122 ;
          prmP00122 = new Object[] {
          new Object[] {"@lV54PedidoWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV55PedidoWWDS_2_Pedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV56PedidoWWDS_3_Pedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV57PedidoWWDS_4_Pedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58PedidoWWDS_5_Pedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV59PedidoWWDS_6_Pedidostatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@AV60PedidoWWDS_7_Tfpedidoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV61PedidoWWDS_8_Tfpedidoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV62PedidoWWDS_9_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV63PedidoWWDS_10_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV64PedidoWWDS_11_Tfpedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV65PedidoWWDS_12_Tfpedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67PedidoWWDS_14_Tfpedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68PedidoWWDS_15_Tfpedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV70PedidoWWDS_17_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV71PedidoWWDS_18_Tfpedidototal_to",SqlDbType.Decimal,12,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00122", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00122,100, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.getBool(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
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
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[19]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[20]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[22]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[23]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[27]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.pedidowwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class pedidowwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("pedidowwgetfilterdata") )
          {
             return  ;
          }
          pedidowwgetfilterdata worker = new pedidowwgetfilterdata(context) ;
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
