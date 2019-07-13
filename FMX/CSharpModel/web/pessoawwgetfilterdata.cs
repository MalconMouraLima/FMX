/*
               File: PessoaWWGetFilterData
        Description: Pessoa WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 18:14:39.91
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
   public class pessoawwgetfilterdata : GXProcedure
   {
      public pessoawwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pessoawwgetfilterdata( IGxContext context )
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
         pessoawwgetfilterdata objpessoawwgetfilterdata;
         objpessoawwgetfilterdata = new pessoawwgetfilterdata();
         objpessoawwgetfilterdata.AV25DDOName = aP0_DDOName;
         objpessoawwgetfilterdata.AV23SearchTxt = aP1_SearchTxt;
         objpessoawwgetfilterdata.AV24SearchTxtTo = aP2_SearchTxtTo;
         objpessoawwgetfilterdata.AV29OptionsJson = "" ;
         objpessoawwgetfilterdata.AV32OptionsDescJson = "" ;
         objpessoawwgetfilterdata.AV34OptionIndexesJson = "" ;
         objpessoawwgetfilterdata.context.SetSubmitInitialConfig(context);
         objpessoawwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpessoawwgetfilterdata);
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pessoawwgetfilterdata)stateInfo).executePrivate();
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
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_PESSOATELEFONE") == 0 )
         {
            /* Execute user subroutine: 'LOADPESSOATELEFONEOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_PESSOAEMAIL") == 0 )
         {
            /* Execute user subroutine: 'LOADPESSOAEMAILOPTIONS' */
            S141 ();
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
         if ( StringUtil.StrCmp(AV36Session.Get("PessoaWWGridState"), "") == 0 )
         {
            AV38GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "PessoaWWGridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV38GridState.FromXml(AV36Session.Get("PessoaWWGridState"), null, "WWPGridState", "FMX");
         }
         AV48GXV1 = 1;
         while ( AV48GXV1 <= AV38GridState.gxTpr_Filtervalues.Count )
         {
            AV39GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV38GridState.gxTpr_Filtervalues.Item(AV48GXV1));
            if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "PESSOANOME") == 0 )
            {
               AV42PessoaNome = AV39GridStateFilterValue.gxTpr_Value;
               AV41PessoaNomeOperator = AV39GridStateFilterValue.gxTpr_Operator;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "PESSOAEMAIL") == 0 )
            {
               AV44PessoaEmail = AV39GridStateFilterValue.gxTpr_Value;
               AV43PessoaEmailOperator = AV39GridStateFilterValue.gxTpr_Operator;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOAID") == 0 )
            {
               AV10TFPessoaId = (short)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV11TFPessoaId_To = (short)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOANOME") == 0 )
            {
               AV12TFPessoaNome = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOANOME_SEL") == 0 )
            {
               AV13TFPessoaNome_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOATELEFONE") == 0 )
            {
               AV16TFPessoaTelefone = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOATELEFONE_SEL") == 0 )
            {
               AV17TFPessoaTelefone_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOAEMAIL") == 0 )
            {
               AV18TFPessoaEmail = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOAEMAIL_SEL") == 0 )
            {
               AV19TFPessoaEmail_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFPESSOASITUACAO_SEL") == 0 )
            {
               AV22TFPessoaSituacao_Sel = (short)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
            }
            AV48GXV1 = (int)(AV48GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADPESSOANOMEOPTIONS' Routine */
         AV12TFPessoaNome = AV23SearchTxt;
         AV13TFPessoaNome_Sel = "";
         AV50PessoaWWDS_1_Pessoanome = AV42PessoaNome;
         AV51PessoaWWDS_2_Pessoaemail = AV44PessoaEmail;
         AV52PessoaWWDS_3_Tfpessoaid = AV10TFPessoaId;
         AV53PessoaWWDS_4_Tfpessoaid_to = AV11TFPessoaId_To;
         AV54PessoaWWDS_5_Tfpessoanome = AV12TFPessoaNome;
         AV55PessoaWWDS_6_Tfpessoanome_sel = AV13TFPessoaNome_Sel;
         AV56PessoaWWDS_7_Tfpessoatelefone = AV16TFPessoaTelefone;
         AV57PessoaWWDS_8_Tfpessoatelefone_sel = AV17TFPessoaTelefone_Sel;
         AV58PessoaWWDS_9_Tfpessoaemail = AV18TFPessoaEmail;
         AV59PessoaWWDS_10_Tfpessoaemail_sel = AV19TFPessoaEmail_Sel;
         AV60PessoaWWDS_11_Tfpessoasituacao_sel = AV22TFPessoaSituacao_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV41PessoaNomeOperator ,
                                              AV50PessoaWWDS_1_Pessoanome ,
                                              AV43PessoaEmailOperator ,
                                              AV51PessoaWWDS_2_Pessoaemail ,
                                              AV52PessoaWWDS_3_Tfpessoaid ,
                                              AV53PessoaWWDS_4_Tfpessoaid_to ,
                                              AV55PessoaWWDS_6_Tfpessoanome_sel ,
                                              AV54PessoaWWDS_5_Tfpessoanome ,
                                              AV57PessoaWWDS_8_Tfpessoatelefone_sel ,
                                              AV56PessoaWWDS_7_Tfpessoatelefone ,
                                              AV59PessoaWWDS_10_Tfpessoaemail_sel ,
                                              AV58PessoaWWDS_9_Tfpessoaemail ,
                                              AV60PessoaWWDS_11_Tfpessoasituacao_sel ,
                                              A2PessoaNome ,
                                              A5PessoaEmail ,
                                              A1PessoaId ,
                                              A4PessoaTelefone ,
                                              A7PessoaSituacao } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV50PessoaWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV50PessoaWWDS_1_Pessoanome), "%", "");
         lV51PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail), "%", "");
         lV51PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail), "%", "");
         lV54PessoaWWDS_5_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV54PessoaWWDS_5_Tfpessoanome), "%", "");
         lV56PessoaWWDS_7_Tfpessoatelefone = StringUtil.Concat( StringUtil.RTrim( AV56PessoaWWDS_7_Tfpessoatelefone), "%", "");
         lV58PessoaWWDS_9_Tfpessoaemail = StringUtil.Concat( StringUtil.RTrim( AV58PessoaWWDS_9_Tfpessoaemail), "%", "");
         /* Using cursor P000W2 */
         pr_default.execute(0, new Object[] {lV50PessoaWWDS_1_Pessoanome, lV51PessoaWWDS_2_Pessoaemail, lV51PessoaWWDS_2_Pessoaemail, AV52PessoaWWDS_3_Tfpessoaid, AV53PessoaWWDS_4_Tfpessoaid_to, lV54PessoaWWDS_5_Tfpessoanome, AV55PessoaWWDS_6_Tfpessoanome_sel, lV56PessoaWWDS_7_Tfpessoatelefone, AV57PessoaWWDS_8_Tfpessoatelefone_sel, lV58PessoaWWDS_9_Tfpessoaemail, AV59PessoaWWDS_10_Tfpessoaemail_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0W2 = false;
            A2PessoaNome = P000W2_A2PessoaNome[0];
            A7PessoaSituacao = P000W2_A7PessoaSituacao[0];
            A4PessoaTelefone = P000W2_A4PessoaTelefone[0];
            A1PessoaId = P000W2_A1PessoaId[0];
            A5PessoaEmail = P000W2_A5PessoaEmail[0];
            AV35count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000W2_A2PessoaNome[0], A2PessoaNome) == 0 ) )
            {
               BRK0W2 = false;
               A1PessoaId = P000W2_A1PessoaId[0];
               AV35count = (long)(AV35count+1);
               BRK0W2 = true;
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
            if ( ! BRK0W2 )
            {
               BRK0W2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADPESSOATELEFONEOPTIONS' Routine */
         AV16TFPessoaTelefone = AV23SearchTxt;
         AV17TFPessoaTelefone_Sel = "";
         AV50PessoaWWDS_1_Pessoanome = AV42PessoaNome;
         AV51PessoaWWDS_2_Pessoaemail = AV44PessoaEmail;
         AV52PessoaWWDS_3_Tfpessoaid = AV10TFPessoaId;
         AV53PessoaWWDS_4_Tfpessoaid_to = AV11TFPessoaId_To;
         AV54PessoaWWDS_5_Tfpessoanome = AV12TFPessoaNome;
         AV55PessoaWWDS_6_Tfpessoanome_sel = AV13TFPessoaNome_Sel;
         AV56PessoaWWDS_7_Tfpessoatelefone = AV16TFPessoaTelefone;
         AV57PessoaWWDS_8_Tfpessoatelefone_sel = AV17TFPessoaTelefone_Sel;
         AV58PessoaWWDS_9_Tfpessoaemail = AV18TFPessoaEmail;
         AV59PessoaWWDS_10_Tfpessoaemail_sel = AV19TFPessoaEmail_Sel;
         AV60PessoaWWDS_11_Tfpessoasituacao_sel = AV22TFPessoaSituacao_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV41PessoaNomeOperator ,
                                              AV50PessoaWWDS_1_Pessoanome ,
                                              AV43PessoaEmailOperator ,
                                              AV51PessoaWWDS_2_Pessoaemail ,
                                              AV52PessoaWWDS_3_Tfpessoaid ,
                                              AV53PessoaWWDS_4_Tfpessoaid_to ,
                                              AV55PessoaWWDS_6_Tfpessoanome_sel ,
                                              AV54PessoaWWDS_5_Tfpessoanome ,
                                              AV57PessoaWWDS_8_Tfpessoatelefone_sel ,
                                              AV56PessoaWWDS_7_Tfpessoatelefone ,
                                              AV59PessoaWWDS_10_Tfpessoaemail_sel ,
                                              AV58PessoaWWDS_9_Tfpessoaemail ,
                                              AV60PessoaWWDS_11_Tfpessoasituacao_sel ,
                                              A2PessoaNome ,
                                              A5PessoaEmail ,
                                              A1PessoaId ,
                                              A4PessoaTelefone ,
                                              A7PessoaSituacao } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV50PessoaWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV50PessoaWWDS_1_Pessoanome), "%", "");
         lV51PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail), "%", "");
         lV51PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail), "%", "");
         lV54PessoaWWDS_5_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV54PessoaWWDS_5_Tfpessoanome), "%", "");
         lV56PessoaWWDS_7_Tfpessoatelefone = StringUtil.Concat( StringUtil.RTrim( AV56PessoaWWDS_7_Tfpessoatelefone), "%", "");
         lV58PessoaWWDS_9_Tfpessoaemail = StringUtil.Concat( StringUtil.RTrim( AV58PessoaWWDS_9_Tfpessoaemail), "%", "");
         /* Using cursor P000W3 */
         pr_default.execute(1, new Object[] {lV50PessoaWWDS_1_Pessoanome, lV51PessoaWWDS_2_Pessoaemail, lV51PessoaWWDS_2_Pessoaemail, AV52PessoaWWDS_3_Tfpessoaid, AV53PessoaWWDS_4_Tfpessoaid_to, lV54PessoaWWDS_5_Tfpessoanome, AV55PessoaWWDS_6_Tfpessoanome_sel, lV56PessoaWWDS_7_Tfpessoatelefone, AV57PessoaWWDS_8_Tfpessoatelefone_sel, lV58PessoaWWDS_9_Tfpessoaemail, AV59PessoaWWDS_10_Tfpessoaemail_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK0W4 = false;
            A4PessoaTelefone = P000W3_A4PessoaTelefone[0];
            A7PessoaSituacao = P000W3_A7PessoaSituacao[0];
            A1PessoaId = P000W3_A1PessoaId[0];
            A5PessoaEmail = P000W3_A5PessoaEmail[0];
            A2PessoaNome = P000W3_A2PessoaNome[0];
            AV35count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P000W3_A4PessoaTelefone[0], A4PessoaTelefone) == 0 ) )
            {
               BRK0W4 = false;
               A1PessoaId = P000W3_A1PessoaId[0];
               AV35count = (long)(AV35count+1);
               BRK0W4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A4PessoaTelefone)) )
            {
               AV27Option = A4PessoaTelefone;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0W4 )
            {
               BRK0W4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADPESSOAEMAILOPTIONS' Routine */
         AV18TFPessoaEmail = AV23SearchTxt;
         AV19TFPessoaEmail_Sel = "";
         AV50PessoaWWDS_1_Pessoanome = AV42PessoaNome;
         AV51PessoaWWDS_2_Pessoaemail = AV44PessoaEmail;
         AV52PessoaWWDS_3_Tfpessoaid = AV10TFPessoaId;
         AV53PessoaWWDS_4_Tfpessoaid_to = AV11TFPessoaId_To;
         AV54PessoaWWDS_5_Tfpessoanome = AV12TFPessoaNome;
         AV55PessoaWWDS_6_Tfpessoanome_sel = AV13TFPessoaNome_Sel;
         AV56PessoaWWDS_7_Tfpessoatelefone = AV16TFPessoaTelefone;
         AV57PessoaWWDS_8_Tfpessoatelefone_sel = AV17TFPessoaTelefone_Sel;
         AV58PessoaWWDS_9_Tfpessoaemail = AV18TFPessoaEmail;
         AV59PessoaWWDS_10_Tfpessoaemail_sel = AV19TFPessoaEmail_Sel;
         AV60PessoaWWDS_11_Tfpessoasituacao_sel = AV22TFPessoaSituacao_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV41PessoaNomeOperator ,
                                              AV50PessoaWWDS_1_Pessoanome ,
                                              AV43PessoaEmailOperator ,
                                              AV51PessoaWWDS_2_Pessoaemail ,
                                              AV52PessoaWWDS_3_Tfpessoaid ,
                                              AV53PessoaWWDS_4_Tfpessoaid_to ,
                                              AV55PessoaWWDS_6_Tfpessoanome_sel ,
                                              AV54PessoaWWDS_5_Tfpessoanome ,
                                              AV57PessoaWWDS_8_Tfpessoatelefone_sel ,
                                              AV56PessoaWWDS_7_Tfpessoatelefone ,
                                              AV59PessoaWWDS_10_Tfpessoaemail_sel ,
                                              AV58PessoaWWDS_9_Tfpessoaemail ,
                                              AV60PessoaWWDS_11_Tfpessoasituacao_sel ,
                                              A2PessoaNome ,
                                              A5PessoaEmail ,
                                              A1PessoaId ,
                                              A4PessoaTelefone ,
                                              A7PessoaSituacao } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV50PessoaWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV50PessoaWWDS_1_Pessoanome), "%", "");
         lV51PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail), "%", "");
         lV51PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail), "%", "");
         lV54PessoaWWDS_5_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV54PessoaWWDS_5_Tfpessoanome), "%", "");
         lV56PessoaWWDS_7_Tfpessoatelefone = StringUtil.Concat( StringUtil.RTrim( AV56PessoaWWDS_7_Tfpessoatelefone), "%", "");
         lV58PessoaWWDS_9_Tfpessoaemail = StringUtil.Concat( StringUtil.RTrim( AV58PessoaWWDS_9_Tfpessoaemail), "%", "");
         /* Using cursor P000W4 */
         pr_default.execute(2, new Object[] {lV50PessoaWWDS_1_Pessoanome, lV51PessoaWWDS_2_Pessoaemail, lV51PessoaWWDS_2_Pessoaemail, AV52PessoaWWDS_3_Tfpessoaid, AV53PessoaWWDS_4_Tfpessoaid_to, lV54PessoaWWDS_5_Tfpessoanome, AV55PessoaWWDS_6_Tfpessoanome_sel, lV56PessoaWWDS_7_Tfpessoatelefone, AV57PessoaWWDS_8_Tfpessoatelefone_sel, lV58PessoaWWDS_9_Tfpessoaemail, AV59PessoaWWDS_10_Tfpessoaemail_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK0W6 = false;
            A5PessoaEmail = P000W4_A5PessoaEmail[0];
            A7PessoaSituacao = P000W4_A7PessoaSituacao[0];
            A4PessoaTelefone = P000W4_A4PessoaTelefone[0];
            A1PessoaId = P000W4_A1PessoaId[0];
            A2PessoaNome = P000W4_A2PessoaNome[0];
            AV35count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P000W4_A5PessoaEmail[0], A5PessoaEmail) == 0 ) )
            {
               BRK0W6 = false;
               A1PessoaId = P000W4_A1PessoaId[0];
               AV35count = (long)(AV35count+1);
               BRK0W6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A5PessoaEmail)) )
            {
               AV27Option = A5PessoaEmail;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0W6 )
            {
               BRK0W6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
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
         AV44PessoaEmail = "";
         AV12TFPessoaNome = "";
         AV13TFPessoaNome_Sel = "";
         AV16TFPessoaTelefone = "";
         AV17TFPessoaTelefone_Sel = "";
         AV18TFPessoaEmail = "";
         AV19TFPessoaEmail_Sel = "";
         AV50PessoaWWDS_1_Pessoanome = "";
         AV51PessoaWWDS_2_Pessoaemail = "";
         AV54PessoaWWDS_5_Tfpessoanome = "";
         AV55PessoaWWDS_6_Tfpessoanome_sel = "";
         AV56PessoaWWDS_7_Tfpessoatelefone = "";
         AV57PessoaWWDS_8_Tfpessoatelefone_sel = "";
         AV58PessoaWWDS_9_Tfpessoaemail = "";
         AV59PessoaWWDS_10_Tfpessoaemail_sel = "";
         scmdbuf = "";
         lV50PessoaWWDS_1_Pessoanome = "";
         lV51PessoaWWDS_2_Pessoaemail = "";
         lV54PessoaWWDS_5_Tfpessoanome = "";
         lV56PessoaWWDS_7_Tfpessoatelefone = "";
         lV58PessoaWWDS_9_Tfpessoaemail = "";
         A2PessoaNome = "";
         A5PessoaEmail = "";
         A4PessoaTelefone = "";
         P000W2_A2PessoaNome = new String[] {""} ;
         P000W2_A7PessoaSituacao = new bool[] {false} ;
         P000W2_A4PessoaTelefone = new String[] {""} ;
         P000W2_A1PessoaId = new short[1] ;
         P000W2_A5PessoaEmail = new String[] {""} ;
         AV27Option = "";
         P000W3_A4PessoaTelefone = new String[] {""} ;
         P000W3_A7PessoaSituacao = new bool[] {false} ;
         P000W3_A1PessoaId = new short[1] ;
         P000W3_A5PessoaEmail = new String[] {""} ;
         P000W3_A2PessoaNome = new String[] {""} ;
         P000W4_A5PessoaEmail = new String[] {""} ;
         P000W4_A7PessoaSituacao = new bool[] {false} ;
         P000W4_A4PessoaTelefone = new String[] {""} ;
         P000W4_A1PessoaId = new short[1] ;
         P000W4_A2PessoaNome = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pessoawwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000W2_A2PessoaNome, P000W2_A7PessoaSituacao, P000W2_A4PessoaTelefone, P000W2_A1PessoaId, P000W2_A5PessoaEmail
               }
               , new Object[] {
               P000W3_A4PessoaTelefone, P000W3_A7PessoaSituacao, P000W3_A1PessoaId, P000W3_A5PessoaEmail, P000W3_A2PessoaNome
               }
               , new Object[] {
               P000W4_A5PessoaEmail, P000W4_A7PessoaSituacao, P000W4_A4PessoaTelefone, P000W4_A1PessoaId, P000W4_A2PessoaNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV41PessoaNomeOperator ;
      private short AV43PessoaEmailOperator ;
      private short AV10TFPessoaId ;
      private short AV11TFPessoaId_To ;
      private short AV22TFPessoaSituacao_Sel ;
      private short AV52PessoaWWDS_3_Tfpessoaid ;
      private short AV53PessoaWWDS_4_Tfpessoaid_to ;
      private short AV60PessoaWWDS_11_Tfpessoasituacao_sel ;
      private short A1PessoaId ;
      private int AV48GXV1 ;
      private long AV35count ;
      private String scmdbuf ;
      private bool returnInSub ;
      private bool A7PessoaSituacao ;
      private bool BRK0W2 ;
      private bool BRK0W4 ;
      private bool BRK0W6 ;
      private String AV34OptionIndexesJson ;
      private String AV29OptionsJson ;
      private String AV32OptionsDescJson ;
      private String AV25DDOName ;
      private String AV23SearchTxt ;
      private String AV24SearchTxtTo ;
      private String AV42PessoaNome ;
      private String AV44PessoaEmail ;
      private String AV12TFPessoaNome ;
      private String AV13TFPessoaNome_Sel ;
      private String AV16TFPessoaTelefone ;
      private String AV17TFPessoaTelefone_Sel ;
      private String AV18TFPessoaEmail ;
      private String AV19TFPessoaEmail_Sel ;
      private String AV50PessoaWWDS_1_Pessoanome ;
      private String AV51PessoaWWDS_2_Pessoaemail ;
      private String AV54PessoaWWDS_5_Tfpessoanome ;
      private String AV55PessoaWWDS_6_Tfpessoanome_sel ;
      private String AV56PessoaWWDS_7_Tfpessoatelefone ;
      private String AV57PessoaWWDS_8_Tfpessoatelefone_sel ;
      private String AV58PessoaWWDS_9_Tfpessoaemail ;
      private String AV59PessoaWWDS_10_Tfpessoaemail_sel ;
      private String lV50PessoaWWDS_1_Pessoanome ;
      private String lV51PessoaWWDS_2_Pessoaemail ;
      private String lV54PessoaWWDS_5_Tfpessoanome ;
      private String lV56PessoaWWDS_7_Tfpessoatelefone ;
      private String lV58PessoaWWDS_9_Tfpessoaemail ;
      private String A2PessoaNome ;
      private String A5PessoaEmail ;
      private String A4PessoaTelefone ;
      private String AV27Option ;
      private IGxSession AV36Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000W2_A2PessoaNome ;
      private bool[] P000W2_A7PessoaSituacao ;
      private String[] P000W2_A4PessoaTelefone ;
      private short[] P000W2_A1PessoaId ;
      private String[] P000W2_A5PessoaEmail ;
      private String[] P000W3_A4PessoaTelefone ;
      private bool[] P000W3_A7PessoaSituacao ;
      private short[] P000W3_A1PessoaId ;
      private String[] P000W3_A5PessoaEmail ;
      private String[] P000W3_A2PessoaNome ;
      private String[] P000W4_A5PessoaEmail ;
      private bool[] P000W4_A7PessoaSituacao ;
      private String[] P000W4_A4PessoaTelefone ;
      private short[] P000W4_A1PessoaId ;
      private String[] P000W4_A2PessoaNome ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV28Options ;
      private GxSimpleCollection<String> AV31OptionsDesc ;
      private GxSimpleCollection<String> AV33OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV38GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV39GridStateFilterValue ;
   }

   public class pessoawwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000W2( IGxContext context ,
                                             short AV41PessoaNomeOperator ,
                                             String AV50PessoaWWDS_1_Pessoanome ,
                                             short AV43PessoaEmailOperator ,
                                             String AV51PessoaWWDS_2_Pessoaemail ,
                                             short AV52PessoaWWDS_3_Tfpessoaid ,
                                             short AV53PessoaWWDS_4_Tfpessoaid_to ,
                                             String AV55PessoaWWDS_6_Tfpessoanome_sel ,
                                             String AV54PessoaWWDS_5_Tfpessoanome ,
                                             String AV57PessoaWWDS_8_Tfpessoatelefone_sel ,
                                             String AV56PessoaWWDS_7_Tfpessoatelefone ,
                                             String AV59PessoaWWDS_10_Tfpessoaemail_sel ,
                                             String AV58PessoaWWDS_9_Tfpessoaemail ,
                                             short AV60PessoaWWDS_11_Tfpessoasituacao_sel ,
                                             String A2PessoaNome ,
                                             String A5PessoaEmail ,
                                             short A1PessoaId ,
                                             String A4PessoaTelefone ,
                                             bool A7PessoaSituacao )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [11] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [PessoaNome], [PessoaSituacao], [PessoaTelefone], [PessoaId], [PessoaEmail] FROM [Pessoa]";
         if ( ( AV41PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50PessoaWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like '%' + @lV50PessoaWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like '%' + @lV50PessoaWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ( AV43PessoaEmailOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV51PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV51PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ( AV43PessoaEmailOperator == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like '%' + @lV51PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like '%' + @lV51PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV52PessoaWWDS_3_Tfpessoaid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] >= @AV52PessoaWWDS_3_Tfpessoaid)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] >= @AV52PessoaWWDS_3_Tfpessoaid)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV53PessoaWWDS_4_Tfpessoaid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] <= @AV53PessoaWWDS_4_Tfpessoaid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] <= @AV53PessoaWWDS_4_Tfpessoaid_to)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV55PessoaWWDS_6_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54PessoaWWDS_5_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like @lV54PessoaWWDS_5_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like @lV54PessoaWWDS_5_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55PessoaWWDS_6_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] = @AV55PessoaWWDS_6_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] = @AV55PessoaWWDS_6_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV57PessoaWWDS_8_Tfpessoatelefone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56PessoaWWDS_7_Tfpessoatelefone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] like @lV56PessoaWWDS_7_Tfpessoatelefone)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] like @lV56PessoaWWDS_7_Tfpessoatelefone)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57PessoaWWDS_8_Tfpessoatelefone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] = @AV57PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] = @AV57PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV59PessoaWWDS_10_Tfpessoaemail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58PessoaWWDS_9_Tfpessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV58PessoaWWDS_9_Tfpessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV58PessoaWWDS_9_Tfpessoaemail)";
            }
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59PessoaWWDS_10_Tfpessoaemail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] = @AV59PessoaWWDS_10_Tfpessoaemail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] = @AV59PessoaWWDS_10_Tfpessoaemail_sel)";
            }
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( AV60PessoaWWDS_11_Tfpessoasituacao_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 1)";
            }
         }
         if ( AV60PessoaWWDS_11_Tfpessoasituacao_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 0)";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [PessoaNome]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P000W3( IGxContext context ,
                                             short AV41PessoaNomeOperator ,
                                             String AV50PessoaWWDS_1_Pessoanome ,
                                             short AV43PessoaEmailOperator ,
                                             String AV51PessoaWWDS_2_Pessoaemail ,
                                             short AV52PessoaWWDS_3_Tfpessoaid ,
                                             short AV53PessoaWWDS_4_Tfpessoaid_to ,
                                             String AV55PessoaWWDS_6_Tfpessoanome_sel ,
                                             String AV54PessoaWWDS_5_Tfpessoanome ,
                                             String AV57PessoaWWDS_8_Tfpessoatelefone_sel ,
                                             String AV56PessoaWWDS_7_Tfpessoatelefone ,
                                             String AV59PessoaWWDS_10_Tfpessoaemail_sel ,
                                             String AV58PessoaWWDS_9_Tfpessoaemail ,
                                             short AV60PessoaWWDS_11_Tfpessoasituacao_sel ,
                                             String A2PessoaNome ,
                                             String A5PessoaEmail ,
                                             short A1PessoaId ,
                                             String A4PessoaTelefone ,
                                             bool A7PessoaSituacao )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [11] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [PessoaTelefone], [PessoaSituacao], [PessoaId], [PessoaEmail], [PessoaNome] FROM [Pessoa]";
         if ( ( AV41PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50PessoaWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like '%' + @lV50PessoaWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like '%' + @lV50PessoaWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ( AV43PessoaEmailOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV51PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV51PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ( AV43PessoaEmailOperator == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like '%' + @lV51PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like '%' + @lV51PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV52PessoaWWDS_3_Tfpessoaid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] >= @AV52PessoaWWDS_3_Tfpessoaid)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] >= @AV52PessoaWWDS_3_Tfpessoaid)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV53PessoaWWDS_4_Tfpessoaid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] <= @AV53PessoaWWDS_4_Tfpessoaid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] <= @AV53PessoaWWDS_4_Tfpessoaid_to)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV55PessoaWWDS_6_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54PessoaWWDS_5_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like @lV54PessoaWWDS_5_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like @lV54PessoaWWDS_5_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55PessoaWWDS_6_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] = @AV55PessoaWWDS_6_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] = @AV55PessoaWWDS_6_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV57PessoaWWDS_8_Tfpessoatelefone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56PessoaWWDS_7_Tfpessoatelefone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] like @lV56PessoaWWDS_7_Tfpessoatelefone)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] like @lV56PessoaWWDS_7_Tfpessoatelefone)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57PessoaWWDS_8_Tfpessoatelefone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] = @AV57PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] = @AV57PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV59PessoaWWDS_10_Tfpessoaemail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58PessoaWWDS_9_Tfpessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV58PessoaWWDS_9_Tfpessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV58PessoaWWDS_9_Tfpessoaemail)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59PessoaWWDS_10_Tfpessoaemail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] = @AV59PessoaWWDS_10_Tfpessoaemail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] = @AV59PessoaWWDS_10_Tfpessoaemail_sel)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( AV60PessoaWWDS_11_Tfpessoasituacao_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 1)";
            }
         }
         if ( AV60PessoaWWDS_11_Tfpessoasituacao_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 0)";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [PessoaTelefone]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_P000W4( IGxContext context ,
                                             short AV41PessoaNomeOperator ,
                                             String AV50PessoaWWDS_1_Pessoanome ,
                                             short AV43PessoaEmailOperator ,
                                             String AV51PessoaWWDS_2_Pessoaemail ,
                                             short AV52PessoaWWDS_3_Tfpessoaid ,
                                             short AV53PessoaWWDS_4_Tfpessoaid_to ,
                                             String AV55PessoaWWDS_6_Tfpessoanome_sel ,
                                             String AV54PessoaWWDS_5_Tfpessoanome ,
                                             String AV57PessoaWWDS_8_Tfpessoatelefone_sel ,
                                             String AV56PessoaWWDS_7_Tfpessoatelefone ,
                                             String AV59PessoaWWDS_10_Tfpessoaemail_sel ,
                                             String AV58PessoaWWDS_9_Tfpessoaemail ,
                                             short AV60PessoaWWDS_11_Tfpessoasituacao_sel ,
                                             String A2PessoaNome ,
                                             String A5PessoaEmail ,
                                             short A1PessoaId ,
                                             String A4PessoaTelefone ,
                                             bool A7PessoaSituacao )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [11] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT [PessoaEmail], [PessoaSituacao], [PessoaTelefone], [PessoaId], [PessoaNome] FROM [Pessoa]";
         if ( ( AV41PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50PessoaWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like '%' + @lV50PessoaWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like '%' + @lV50PessoaWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ( AV43PessoaEmailOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV51PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV51PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ( AV43PessoaEmailOperator == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like '%' + @lV51PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like '%' + @lV51PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV52PessoaWWDS_3_Tfpessoaid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] >= @AV52PessoaWWDS_3_Tfpessoaid)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] >= @AV52PessoaWWDS_3_Tfpessoaid)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (0==AV53PessoaWWDS_4_Tfpessoaid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] <= @AV53PessoaWWDS_4_Tfpessoaid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] <= @AV53PessoaWWDS_4_Tfpessoaid_to)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV55PessoaWWDS_6_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54PessoaWWDS_5_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like @lV54PessoaWWDS_5_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like @lV54PessoaWWDS_5_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55PessoaWWDS_6_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] = @AV55PessoaWWDS_6_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] = @AV55PessoaWWDS_6_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV57PessoaWWDS_8_Tfpessoatelefone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56PessoaWWDS_7_Tfpessoatelefone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] like @lV56PessoaWWDS_7_Tfpessoatelefone)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] like @lV56PessoaWWDS_7_Tfpessoatelefone)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57PessoaWWDS_8_Tfpessoatelefone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] = @AV57PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] = @AV57PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV59PessoaWWDS_10_Tfpessoaemail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58PessoaWWDS_9_Tfpessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV58PessoaWWDS_9_Tfpessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV58PessoaWWDS_9_Tfpessoaemail)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59PessoaWWDS_10_Tfpessoaemail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] = @AV59PessoaWWDS_10_Tfpessoaemail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] = @AV59PessoaWWDS_10_Tfpessoaemail_sel)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( AV60PessoaWWDS_11_Tfpessoasituacao_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 1)";
            }
         }
         if ( AV60PessoaWWDS_11_Tfpessoasituacao_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 0)";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [PessoaEmail]";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000W2(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (String)dynConstraints[16] , (bool)dynConstraints[17] );
               case 1 :
                     return conditional_P000W3(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (String)dynConstraints[16] , (bool)dynConstraints[17] );
               case 2 :
                     return conditional_P000W4(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (String)dynConstraints[16] , (bool)dynConstraints[17] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000W2 ;
          prmP000W2 = new Object[] {
          new Object[] {"@lV50PessoaWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV51PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV51PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV52PessoaWWDS_3_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV53PessoaWWDS_4_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV54PessoaWWDS_5_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV55PessoaWWDS_6_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV56PessoaWWDS_7_Tfpessoatelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@AV57PessoaWWDS_8_Tfpessoatelefone_sel",SqlDbType.VarChar,11,0} ,
          new Object[] {"@lV58PessoaWWDS_9_Tfpessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV59PessoaWWDS_10_Tfpessoaemail_sel",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmP000W3 ;
          prmP000W3 = new Object[] {
          new Object[] {"@lV50PessoaWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV51PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV51PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV52PessoaWWDS_3_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV53PessoaWWDS_4_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV54PessoaWWDS_5_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV55PessoaWWDS_6_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV56PessoaWWDS_7_Tfpessoatelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@AV57PessoaWWDS_8_Tfpessoatelefone_sel",SqlDbType.VarChar,11,0} ,
          new Object[] {"@lV58PessoaWWDS_9_Tfpessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV59PessoaWWDS_10_Tfpessoaemail_sel",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmP000W4 ;
          prmP000W4 = new Object[] {
          new Object[] {"@lV50PessoaWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV51PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV51PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV52PessoaWWDS_3_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV53PessoaWWDS_4_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV54PessoaWWDS_5_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV55PessoaWWDS_6_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV56PessoaWWDS_7_Tfpessoatelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@AV57PessoaWWDS_8_Tfpessoatelefone_sel",SqlDbType.VarChar,11,0} ,
          new Object[] {"@lV58PessoaWWDS_9_Tfpessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV59PessoaWWDS_10_Tfpessoaemail_sel",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P000W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W3,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P000W4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W4,100, GxCacheFrequency.OFF ,true,false )
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.pessoawwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class pessoawwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("pessoawwgetfilterdata") )
          {
             return  ;
          }
          pessoawwgetfilterdata worker = new pessoawwgetfilterdata(context) ;
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
