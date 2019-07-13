/*
               File: WP_GerenciarPedidoGetFilterData
        Description: WP_Gerenciar Pedido Get Filter Data
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:28.18
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
   public class wp_gerenciarpedidogetfilterdata : GXProcedure
   {
      public wp_gerenciarpedidogetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wp_gerenciarpedidogetfilterdata( IGxContext context )
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
         this.AV27DDOName = aP0_DDOName;
         this.AV25SearchTxt = aP1_SearchTxt;
         this.AV26SearchTxtTo = aP2_SearchTxtTo;
         this.AV31OptionsJson = "" ;
         this.AV34OptionsDescJson = "" ;
         this.AV36OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV31OptionsJson;
         aP4_OptionsDescJson=this.AV34OptionsDescJson;
         aP5_OptionIndexesJson=this.AV36OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV27DDOName = aP0_DDOName;
         this.AV25SearchTxt = aP1_SearchTxt;
         this.AV26SearchTxtTo = aP2_SearchTxtTo;
         this.AV31OptionsJson = "" ;
         this.AV34OptionsDescJson = "" ;
         this.AV36OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV31OptionsJson;
         aP4_OptionsDescJson=this.AV34OptionsDescJson;
         aP5_OptionIndexesJson=this.AV36OptionIndexesJson;
         return AV36OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         wp_gerenciarpedidogetfilterdata objwp_gerenciarpedidogetfilterdata;
         objwp_gerenciarpedidogetfilterdata = new wp_gerenciarpedidogetfilterdata();
         objwp_gerenciarpedidogetfilterdata.AV27DDOName = aP0_DDOName;
         objwp_gerenciarpedidogetfilterdata.AV25SearchTxt = aP1_SearchTxt;
         objwp_gerenciarpedidogetfilterdata.AV26SearchTxtTo = aP2_SearchTxtTo;
         objwp_gerenciarpedidogetfilterdata.AV31OptionsJson = "" ;
         objwp_gerenciarpedidogetfilterdata.AV34OptionsDescJson = "" ;
         objwp_gerenciarpedidogetfilterdata.AV36OptionIndexesJson = "" ;
         objwp_gerenciarpedidogetfilterdata.context.SetSubmitInitialConfig(context);
         objwp_gerenciarpedidogetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwp_gerenciarpedidogetfilterdata);
         aP3_OptionsJson=this.AV31OptionsJson;
         aP4_OptionsDescJson=this.AV34OptionsDescJson;
         aP5_OptionIndexesJson=this.AV36OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wp_gerenciarpedidogetfilterdata)stateInfo).executePrivate();
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
         AV30Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV33OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV35OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV27DDOName), "DDO_PESSOANOME") == 0 )
         {
            /* Execute user subroutine: 'LOADPESSOANOMEOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV31OptionsJson = AV30Options.ToJSonString(false);
         AV34OptionsDescJson = AV33OptionsDesc.ToJSonString(false);
         AV36OptionIndexesJson = AV35OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV38Session.Get("WP_GerenciarPedidoGridState"), "") == 0 )
         {
            AV40GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WP_GerenciarPedidoGridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV40GridState.FromXml(AV38Session.Get("WP_GerenciarPedidoGridState"), null, "WWPGridState", "FMX");
         }
         AV59GXV1 = 1;
         while ( AV59GXV1 <= AV40GridState.gxTpr_Filtervalues.Count )
         {
            AV41GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV40GridState.gxTpr_Filtervalues.Item(AV59GXV1));
            if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPEDIDOID") == 0 )
            {
               AV10TFPedidoId = (short)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, "."));
               AV11TFPedidoId_To = (short)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPESSOAID") == 0 )
            {
               AV12TFPessoaId = (short)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, "."));
               AV13TFPessoaId_To = (short)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPESSOANOME") == 0 )
            {
               AV14TFPessoaNome = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPESSOANOME_SEL") == 0 )
            {
               AV15TFPessoaNome_Sel = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPEDIDODT") == 0 )
            {
               AV16TFPedidoDt = context.localUtil.CToD( AV41GridStateFilterValue.gxTpr_Value, 2);
               AV17TFPedidoDt_To = context.localUtil.CToD( AV41GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPEDIDOSTATUS_SEL") == 0 )
            {
               AV18TFPedidoStatus_SelsJson = AV41GridStateFilterValue.gxTpr_Value;
               AV19TFPedidoStatus_Sels.FromJSonString(AV18TFPedidoStatus_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPEDIDODTENTREGA") == 0 )
            {
               AV20TFPedidoDtEntrega = context.localUtil.CToD( AV41GridStateFilterValue.gxTpr_Value, 2);
               AV21TFPedidoDtEntrega_To = context.localUtil.CToD( AV41GridStateFilterValue.gxTpr_Valueto, 2);
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPEDIDORETIRADA_SEL") == 0 )
            {
               AV22TFPedidoRetirada_Sel = (short)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFPEDIDOTOTAL") == 0 )
            {
               AV23TFPedidoTotal = NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, ".");
               AV24TFPedidoTotal_To = NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, ".");
            }
            AV59GXV1 = (int)(AV59GXV1+1);
         }
         if ( AV40GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV42GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV40GridState.gxTpr_Dynamicfilters.Item(1));
            AV43DynamicFiltersSelector1 = AV42GridStateDynamicFilter.gxTpr_Selected;
            if ( StringUtil.StrCmp(AV43DynamicFiltersSelector1, "PEDIDODT") == 0 )
            {
               AV44DynamicFiltersOperator1 = AV42GridStateDynamicFilter.gxTpr_Operator;
               AV45PedidoDt1 = context.localUtil.CToD( AV42GridStateDynamicFilter.gxTpr_Value, 2);
               AV46PedidoDt_To1 = context.localUtil.CToD( AV42GridStateDynamicFilter.gxTpr_Valueto, 2);
            }
            if ( AV40GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               AV47DynamicFiltersEnabled2 = true;
               AV42GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV40GridState.gxTpr_Dynamicfilters.Item(2));
               AV48DynamicFiltersSelector2 = AV42GridStateDynamicFilter.gxTpr_Selected;
               if ( StringUtil.StrCmp(AV48DynamicFiltersSelector2, "PEDIDODT") == 0 )
               {
                  AV49DynamicFiltersOperator2 = AV42GridStateDynamicFilter.gxTpr_Operator;
                  AV50PedidoDt2 = context.localUtil.CToD( AV42GridStateDynamicFilter.gxTpr_Value, 2);
                  AV51PedidoDt_To2 = context.localUtil.CToD( AV42GridStateDynamicFilter.gxTpr_Valueto, 2);
               }
               if ( AV40GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  AV52DynamicFiltersEnabled3 = true;
                  AV42GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV40GridState.gxTpr_Dynamicfilters.Item(3));
                  AV53DynamicFiltersSelector3 = AV42GridStateDynamicFilter.gxTpr_Selected;
                  if ( StringUtil.StrCmp(AV53DynamicFiltersSelector3, "PEDIDODT") == 0 )
                  {
                     AV54DynamicFiltersOperator3 = AV42GridStateDynamicFilter.gxTpr_Operator;
                     AV55PedidoDt3 = context.localUtil.CToD( AV42GridStateDynamicFilter.gxTpr_Value, 2);
                     AV56PedidoDt_To3 = context.localUtil.CToD( AV42GridStateDynamicFilter.gxTpr_Valueto, 2);
                  }
               }
            }
         }
      }

      protected void S121( )
      {
         /* 'LOADPESSOANOMEOPTIONS' Routine */
         AV14TFPessoaNome = AV25SearchTxt;
         AV15TFPessoaNome_Sel = "";
         AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV43DynamicFiltersSelector1;
         AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV44DynamicFiltersOperator1;
         AV63WP_GerenciarPedidoDS_3_Pedidodt1 = AV45PedidoDt1;
         AV64WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV46PedidoDt_To1;
         AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV47DynamicFiltersEnabled2;
         AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV48DynamicFiltersSelector2;
         AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV49DynamicFiltersOperator2;
         AV68WP_GerenciarPedidoDS_8_Pedidodt2 = AV50PedidoDt2;
         AV69WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV51PedidoDt_To2;
         AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV52DynamicFiltersEnabled3;
         AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV53DynamicFiltersSelector3;
         AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV54DynamicFiltersOperator3;
         AV73WP_GerenciarPedidoDS_13_Pedidodt3 = AV55PedidoDt3;
         AV74WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV56PedidoDt_To3;
         AV75WP_GerenciarPedidoDS_15_Tfpedidoid = AV10TFPedidoId;
         AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV11TFPedidoId_To;
         AV77WP_GerenciarPedidoDS_17_Tfpessoaid = AV12TFPessoaId;
         AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV13TFPessoaId_To;
         AV79WP_GerenciarPedidoDS_19_Tfpessoanome = AV14TFPessoaNome;
         AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV15TFPessoaNome_Sel;
         AV81WP_GerenciarPedidoDS_21_Tfpedidodt = AV16TFPedidoDt;
         AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV17TFPedidoDt_To;
         AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV19TFPedidoStatus_Sels;
         AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV20TFPedidoDtEntrega;
         AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV21TFPedidoDtEntrega_To;
         AV86WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV22TFPedidoRetirada_Sel;
         AV87WP_GerenciarPedidoDS_27_Tfpedidototal = AV23TFPedidoTotal;
         AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV24TFPedidoTotal_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A34PedidoStatus ,
                                              AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ,
                                              AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ,
                                              AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ,
                                              AV63WP_GerenciarPedidoDS_3_Pedidodt1 ,
                                              AV64WP_GerenciarPedidoDS_4_Pedidodt_to1 ,
                                              AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ,
                                              AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ,
                                              AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ,
                                              AV68WP_GerenciarPedidoDS_8_Pedidodt2 ,
                                              AV69WP_GerenciarPedidoDS_9_Pedidodt_to2 ,
                                              AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ,
                                              AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ,
                                              AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ,
                                              AV73WP_GerenciarPedidoDS_13_Pedidodt3 ,
                                              AV74WP_GerenciarPedidoDS_14_Pedidodt_to3 ,
                                              AV75WP_GerenciarPedidoDS_15_Tfpedidoid ,
                                              AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to ,
                                              AV77WP_GerenciarPedidoDS_17_Tfpessoaid ,
                                              AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to ,
                                              AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel ,
                                              AV79WP_GerenciarPedidoDS_19_Tfpessoanome ,
                                              AV81WP_GerenciarPedidoDS_21_Tfpedidodt ,
                                              AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to ,
                                              AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels.Count ,
                                              AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega ,
                                              AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ,
                                              AV86WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ,
                                              AV87WP_GerenciarPedidoDS_27_Tfpedidototal ,
                                              AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to ,
                                              A33PedidoDt ,
                                              A32PedidoId ,
                                              A1PessoaId ,
                                              A2PessoaNome ,
                                              A35PedidoDtEntrega ,
                                              A36PedidoRetirada ,
                                              A37PedidoTotal } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DATE,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DECIMAL
                                              }
         } ) ;
         lV79WP_GerenciarPedidoDS_19_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV79WP_GerenciarPedidoDS_19_Tfpessoanome), "%", "");
         /* Using cursor P00112 */
         pr_default.execute(0, new Object[] {AV63WP_GerenciarPedidoDS_3_Pedidodt1, AV63WP_GerenciarPedidoDS_3_Pedidodt1, AV63WP_GerenciarPedidoDS_3_Pedidodt1, AV63WP_GerenciarPedidoDS_3_Pedidodt1, AV64WP_GerenciarPedidoDS_4_Pedidodt_to1, AV68WP_GerenciarPedidoDS_8_Pedidodt2, AV68WP_GerenciarPedidoDS_8_Pedidodt2, AV68WP_GerenciarPedidoDS_8_Pedidodt2, AV68WP_GerenciarPedidoDS_8_Pedidodt2, AV69WP_GerenciarPedidoDS_9_Pedidodt_to2, AV73WP_GerenciarPedidoDS_13_Pedidodt3, AV73WP_GerenciarPedidoDS_13_Pedidodt3, AV73WP_GerenciarPedidoDS_13_Pedidodt3, AV73WP_GerenciarPedidoDS_13_Pedidodt3, AV74WP_GerenciarPedidoDS_14_Pedidodt_to3, AV75WP_GerenciarPedidoDS_15_Tfpedidoid, AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to, AV77WP_GerenciarPedidoDS_17_Tfpessoaid, AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to, lV79WP_GerenciarPedidoDS_19_Tfpessoanome, AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel, AV81WP_GerenciarPedidoDS_21_Tfpedidodt, AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to, AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega, AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to, AV87WP_GerenciarPedidoDS_27_Tfpedidototal, AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK112 = false;
            A2PessoaNome = P00112_A2PessoaNome[0];
            A37PedidoTotal = P00112_A37PedidoTotal[0];
            A36PedidoRetirada = P00112_A36PedidoRetirada[0];
            A35PedidoDtEntrega = P00112_A35PedidoDtEntrega[0];
            A34PedidoStatus = P00112_A34PedidoStatus[0];
            A1PessoaId = P00112_A1PessoaId[0];
            A32PedidoId = P00112_A32PedidoId[0];
            A33PedidoDt = P00112_A33PedidoDt[0];
            A2PessoaNome = P00112_A2PessoaNome[0];
            AV37count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00112_A2PessoaNome[0], A2PessoaNome) == 0 ) )
            {
               BRK112 = false;
               A1PessoaId = P00112_A1PessoaId[0];
               A32PedidoId = P00112_A32PedidoId[0];
               AV37count = (long)(AV37count+1);
               BRK112 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A2PessoaNome)) )
            {
               AV29Option = A2PessoaNome;
               AV30Options.Add(AV29Option, 0);
               AV35OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV37count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV30Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK112 )
            {
               BRK112 = true;
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
         AV30Options = new GxSimpleCollection<String>();
         AV33OptionsDesc = new GxSimpleCollection<String>();
         AV35OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV38Session = context.GetSession();
         AV40GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV41GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV14TFPessoaNome = "";
         AV15TFPessoaNome_Sel = "";
         AV16TFPedidoDt = DateTime.MinValue;
         AV17TFPedidoDt_To = DateTime.MinValue;
         AV18TFPedidoStatus_SelsJson = "";
         AV19TFPedidoStatus_Sels = new GxSimpleCollection<String>();
         AV20TFPedidoDtEntrega = DateTime.MinValue;
         AV21TFPedidoDtEntrega_To = DateTime.MinValue;
         AV42GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV43DynamicFiltersSelector1 = "";
         AV45PedidoDt1 = DateTime.MinValue;
         AV46PedidoDt_To1 = DateTime.MinValue;
         AV48DynamicFiltersSelector2 = "";
         AV50PedidoDt2 = DateTime.MinValue;
         AV51PedidoDt_To2 = DateTime.MinValue;
         AV53DynamicFiltersSelector3 = "";
         AV55PedidoDt3 = DateTime.MinValue;
         AV56PedidoDt_To3 = DateTime.MinValue;
         AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = "";
         AV63WP_GerenciarPedidoDS_3_Pedidodt1 = DateTime.MinValue;
         AV64WP_GerenciarPedidoDS_4_Pedidodt_to1 = DateTime.MinValue;
         AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = "";
         AV68WP_GerenciarPedidoDS_8_Pedidodt2 = DateTime.MinValue;
         AV69WP_GerenciarPedidoDS_9_Pedidodt_to2 = DateTime.MinValue;
         AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = "";
         AV73WP_GerenciarPedidoDS_13_Pedidodt3 = DateTime.MinValue;
         AV74WP_GerenciarPedidoDS_14_Pedidodt_to3 = DateTime.MinValue;
         AV79WP_GerenciarPedidoDS_19_Tfpessoanome = "";
         AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel = "";
         AV81WP_GerenciarPedidoDS_21_Tfpedidodt = DateTime.MinValue;
         AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to = DateTime.MinValue;
         AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = new GxSimpleCollection<String>();
         AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega = DateTime.MinValue;
         AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = DateTime.MinValue;
         scmdbuf = "";
         lV79WP_GerenciarPedidoDS_19_Tfpessoanome = "";
         A34PedidoStatus = "";
         A33PedidoDt = DateTime.MinValue;
         A2PessoaNome = "";
         A35PedidoDtEntrega = DateTime.MinValue;
         P00112_A2PessoaNome = new String[] {""} ;
         P00112_A37PedidoTotal = new decimal[1] ;
         P00112_A36PedidoRetirada = new bool[] {false} ;
         P00112_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         P00112_A34PedidoStatus = new String[] {""} ;
         P00112_A1PessoaId = new short[1] ;
         P00112_A32PedidoId = new short[1] ;
         P00112_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         AV29Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_gerenciarpedidogetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00112_A2PessoaNome, P00112_A37PedidoTotal, P00112_A36PedidoRetirada, P00112_A35PedidoDtEntrega, P00112_A34PedidoStatus, P00112_A1PessoaId, P00112_A32PedidoId, P00112_A33PedidoDt
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10TFPedidoId ;
      private short AV11TFPedidoId_To ;
      private short AV12TFPessoaId ;
      private short AV13TFPessoaId_To ;
      private short AV22TFPedidoRetirada_Sel ;
      private short AV44DynamicFiltersOperator1 ;
      private short AV49DynamicFiltersOperator2 ;
      private short AV54DynamicFiltersOperator3 ;
      private short AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ;
      private short AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ;
      private short AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ;
      private short AV75WP_GerenciarPedidoDS_15_Tfpedidoid ;
      private short AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to ;
      private short AV77WP_GerenciarPedidoDS_17_Tfpessoaid ;
      private short AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to ;
      private short AV86WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ;
      private short A32PedidoId ;
      private short A1PessoaId ;
      private int AV59GXV1 ;
      private int AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count ;
      private long AV37count ;
      private decimal AV23TFPedidoTotal ;
      private decimal AV24TFPedidoTotal_To ;
      private decimal AV87WP_GerenciarPedidoDS_27_Tfpedidototal ;
      private decimal AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to ;
      private decimal A37PedidoTotal ;
      private String scmdbuf ;
      private DateTime AV16TFPedidoDt ;
      private DateTime AV17TFPedidoDt_To ;
      private DateTime AV20TFPedidoDtEntrega ;
      private DateTime AV21TFPedidoDtEntrega_To ;
      private DateTime AV45PedidoDt1 ;
      private DateTime AV46PedidoDt_To1 ;
      private DateTime AV50PedidoDt2 ;
      private DateTime AV51PedidoDt_To2 ;
      private DateTime AV55PedidoDt3 ;
      private DateTime AV56PedidoDt_To3 ;
      private DateTime AV63WP_GerenciarPedidoDS_3_Pedidodt1 ;
      private DateTime AV64WP_GerenciarPedidoDS_4_Pedidodt_to1 ;
      private DateTime AV68WP_GerenciarPedidoDS_8_Pedidodt2 ;
      private DateTime AV69WP_GerenciarPedidoDS_9_Pedidodt_to2 ;
      private DateTime AV73WP_GerenciarPedidoDS_13_Pedidodt3 ;
      private DateTime AV74WP_GerenciarPedidoDS_14_Pedidodt_to3 ;
      private DateTime AV81WP_GerenciarPedidoDS_21_Tfpedidodt ;
      private DateTime AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to ;
      private DateTime AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega ;
      private DateTime AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ;
      private DateTime A33PedidoDt ;
      private DateTime A35PedidoDtEntrega ;
      private bool returnInSub ;
      private bool AV47DynamicFiltersEnabled2 ;
      private bool AV52DynamicFiltersEnabled3 ;
      private bool AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ;
      private bool AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ;
      private bool A36PedidoRetirada ;
      private bool BRK112 ;
      private String AV36OptionIndexesJson ;
      private String AV31OptionsJson ;
      private String AV34OptionsDescJson ;
      private String AV18TFPedidoStatus_SelsJson ;
      private String AV27DDOName ;
      private String AV25SearchTxt ;
      private String AV26SearchTxtTo ;
      private String AV14TFPessoaNome ;
      private String AV15TFPessoaNome_Sel ;
      private String AV43DynamicFiltersSelector1 ;
      private String AV48DynamicFiltersSelector2 ;
      private String AV53DynamicFiltersSelector3 ;
      private String AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ;
      private String AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ;
      private String AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ;
      private String AV79WP_GerenciarPedidoDS_19_Tfpessoanome ;
      private String AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel ;
      private String lV79WP_GerenciarPedidoDS_19_Tfpessoanome ;
      private String A34PedidoStatus ;
      private String A2PessoaNome ;
      private String AV29Option ;
      private IGxSession AV38Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00112_A2PessoaNome ;
      private decimal[] P00112_A37PedidoTotal ;
      private bool[] P00112_A36PedidoRetirada ;
      private DateTime[] P00112_A35PedidoDtEntrega ;
      private String[] P00112_A34PedidoStatus ;
      private short[] P00112_A1PessoaId ;
      private short[] P00112_A32PedidoId ;
      private DateTime[] P00112_A33PedidoDt ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV30Options ;
      private GxSimpleCollection<String> AV33OptionsDesc ;
      private GxSimpleCollection<String> AV35OptionIndexes ;
      private GxSimpleCollection<String> AV19TFPedidoStatus_Sels ;
      private GxSimpleCollection<String> AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV40GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV41GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV42GridStateDynamicFilter ;
   }

   public class wp_gerenciarpedidogetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00112( IGxContext context ,
                                             String A34PedidoStatus ,
                                             GxSimpleCollection<String> AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ,
                                             String AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ,
                                             short AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ,
                                             DateTime AV63WP_GerenciarPedidoDS_3_Pedidodt1 ,
                                             DateTime AV64WP_GerenciarPedidoDS_4_Pedidodt_to1 ,
                                             bool AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ,
                                             String AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ,
                                             short AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ,
                                             DateTime AV68WP_GerenciarPedidoDS_8_Pedidodt2 ,
                                             DateTime AV69WP_GerenciarPedidoDS_9_Pedidodt_to2 ,
                                             bool AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ,
                                             String AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ,
                                             short AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ,
                                             DateTime AV73WP_GerenciarPedidoDS_13_Pedidodt3 ,
                                             DateTime AV74WP_GerenciarPedidoDS_14_Pedidodt_to3 ,
                                             short AV75WP_GerenciarPedidoDS_15_Tfpedidoid ,
                                             short AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to ,
                                             short AV77WP_GerenciarPedidoDS_17_Tfpessoaid ,
                                             short AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to ,
                                             String AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel ,
                                             String AV79WP_GerenciarPedidoDS_19_Tfpessoanome ,
                                             DateTime AV81WP_GerenciarPedidoDS_21_Tfpedidodt ,
                                             DateTime AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to ,
                                             int AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count ,
                                             DateTime AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega ,
                                             DateTime AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ,
                                             short AV86WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ,
                                             decimal AV87WP_GerenciarPedidoDS_27_Tfpedidototal ,
                                             decimal AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to ,
                                             DateTime A33PedidoDt ,
                                             short A32PedidoId ,
                                             short A1PessoaId ,
                                             String A2PessoaNome ,
                                             DateTime A35PedidoDtEntrega ,
                                             bool A36PedidoRetirada ,
                                             decimal A37PedidoTotal )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [27] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T2.[PessoaNome], T1.[PedidoTotal], T1.[PedidoRetirada], T1.[PedidoDtEntrega], T1.[PedidoStatus], T1.[PessoaId], T1.[PedidoId], T1.[PedidoDt] FROM ([Pedido] T1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = T1.[PessoaId])";
         if ( ( StringUtil.StrCmp(AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! (DateTime.MinValue==AV63WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] < @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! (DateTime.MinValue==AV63WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] = @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 2 ) && ( ! (DateTime.MinValue==AV63WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] > @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 3 ) && ( ! (DateTime.MinValue==AV63WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV63WP_GerenciarPedidoDS_3_Pedidodt1)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV61WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV62WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 3 ) && ( ! (DateTime.MinValue==AV64WP_GerenciarPedidoDS_4_Pedidodt_to1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV64WP_GerenciarPedidoDS_4_Pedidodt_to1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV64WP_GerenciarPedidoDS_4_Pedidodt_to1)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 0 ) && ( ! (DateTime.MinValue==AV68WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] < @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 1 ) && ( ! (DateTime.MinValue==AV68WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] = @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 2 ) && ( ! (DateTime.MinValue==AV68WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] > @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 3 ) && ( ! (DateTime.MinValue==AV68WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV68WP_GerenciarPedidoDS_8_Pedidodt2)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( AV65WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV66WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV67WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 3 ) && ( ! (DateTime.MinValue==AV69WP_GerenciarPedidoDS_9_Pedidodt_to2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV69WP_GerenciarPedidoDS_9_Pedidodt_to2)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV69WP_GerenciarPedidoDS_9_Pedidodt_to2)";
            }
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 0 ) && ( ! (DateTime.MinValue==AV73WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] < @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 1 ) && ( ! (DateTime.MinValue==AV73WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] = @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 2 ) && ( ! (DateTime.MinValue==AV73WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] > @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
         }
         else
         {
            GXv_int1[12] = 1;
         }
         if ( AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 3 ) && ( ! (DateTime.MinValue==AV73WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV73WP_GerenciarPedidoDS_13_Pedidodt3)";
            }
         }
         else
         {
            GXv_int1[13] = 1;
         }
         if ( AV70WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV71WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV72WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 3 ) && ( ! (DateTime.MinValue==AV74WP_GerenciarPedidoDS_14_Pedidodt_to3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV74WP_GerenciarPedidoDS_14_Pedidodt_to3)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV74WP_GerenciarPedidoDS_14_Pedidodt_to3)";
            }
         }
         else
         {
            GXv_int1[14] = 1;
         }
         if ( ! (0==AV75WP_GerenciarPedidoDS_15_Tfpedidoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] >= @AV75WP_GerenciarPedidoDS_15_Tfpedidoid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] >= @AV75WP_GerenciarPedidoDS_15_Tfpedidoid)";
            }
         }
         else
         {
            GXv_int1[15] = 1;
         }
         if ( ! (0==AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] <= @AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] <= @AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to)";
            }
         }
         else
         {
            GXv_int1[16] = 1;
         }
         if ( ! (0==AV77WP_GerenciarPedidoDS_17_Tfpessoaid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PessoaId] >= @AV77WP_GerenciarPedidoDS_17_Tfpessoaid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PessoaId] >= @AV77WP_GerenciarPedidoDS_17_Tfpessoaid)";
            }
         }
         else
         {
            GXv_int1[17] = 1;
         }
         if ( ! (0==AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PessoaId] <= @AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PessoaId] <= @AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to)";
            }
         }
         else
         {
            GXv_int1[18] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79WP_GerenciarPedidoDS_19_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like @lV79WP_GerenciarPedidoDS_19_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like @lV79WP_GerenciarPedidoDS_19_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int1[19] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] = @AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] = @AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int1[20] = 1;
         }
         if ( ! (DateTime.MinValue==AV81WP_GerenciarPedidoDS_21_Tfpedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV81WP_GerenciarPedidoDS_21_Tfpedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV81WP_GerenciarPedidoDS_21_Tfpedidodt)";
            }
         }
         else
         {
            GXv_int1[21] = 1;
         }
         if ( ! (DateTime.MinValue==AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to)";
            }
         }
         else
         {
            GXv_int1[22] = 1;
         }
         if ( AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV83WP_GerenciarPedidoDS_23_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega)";
            }
         }
         else
         {
            GXv_int1[23] = 1;
         }
         if ( ! (DateTime.MinValue==AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int1[24] = 1;
         }
         if ( AV86WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel == 1 )
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
         if ( AV86WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel == 2 )
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
         if ( ! (Convert.ToDecimal(0)==AV87WP_GerenciarPedidoDS_27_Tfpedidototal) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] >= @AV87WP_GerenciarPedidoDS_27_Tfpedidototal)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] >= @AV87WP_GerenciarPedidoDS_27_Tfpedidototal)";
            }
         }
         else
         {
            GXv_int1[25] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] <= @AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] <= @AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to)";
            }
         }
         else
         {
            GXv_int1[26] = 1;
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
                     return conditional_P00112(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (bool)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (bool)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (DateTime)dynConstraints[14] , (DateTime)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (short)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (DateTime)dynConstraints[22] , (DateTime)dynConstraints[23] , (int)dynConstraints[24] , (DateTime)dynConstraints[25] , (DateTime)dynConstraints[26] , (short)dynConstraints[27] , (decimal)dynConstraints[28] , (decimal)dynConstraints[29] , (DateTime)dynConstraints[30] , (short)dynConstraints[31] , (short)dynConstraints[32] , (String)dynConstraints[33] , (DateTime)dynConstraints[34] , (bool)dynConstraints[35] , (decimal)dynConstraints[36] );
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
          Object[] prmP00112 ;
          prmP00112 = new Object[] {
          new Object[] {"@AV63WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV63WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV63WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV63WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV64WP_GerenciarPedidoDS_4_Pedidodt_to1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV69WP_GerenciarPedidoDS_9_Pedidodt_to2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV73WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV73WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV73WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV73WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74WP_GerenciarPedidoDS_14_Pedidodt_to3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV75WP_GerenciarPedidoDS_15_Tfpedidoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV76WP_GerenciarPedidoDS_16_Tfpedidoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV77WP_GerenciarPedidoDS_17_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV78WP_GerenciarPedidoDS_18_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV79WP_GerenciarPedidoDS_19_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV80WP_GerenciarPedidoDS_20_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV81WP_GerenciarPedidoDS_21_Tfpedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV82WP_GerenciarPedidoDS_22_Tfpedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV84WP_GerenciarPedidoDS_24_Tfpedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV85WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV87WP_GerenciarPedidoDS_27_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV88WP_GerenciarPedidoDS_28_Tfpedidototal_to",SqlDbType.Decimal,12,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00112", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00112,100, GxCacheFrequency.OFF ,true,false )
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
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[27]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[33]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[34]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[35]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[38]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[39]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[40]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[41]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[42]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[43]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[44]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[45]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[48]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[49]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[50]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[51]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[52]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[53]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.wp_gerenciarpedidogetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class wp_gerenciarpedidogetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("wp_gerenciarpedidogetfilterdata") )
          {
             return  ;
          }
          wp_gerenciarpedidogetfilterdata worker = new wp_gerenciarpedidogetfilterdata(context) ;
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
