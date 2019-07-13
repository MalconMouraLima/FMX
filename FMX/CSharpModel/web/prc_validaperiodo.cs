/*
               File: PRC_ValidaPeriodo
        Description: Valida Periodo Vigente
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 10:37:43.96
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class prc_validaperiodo : GXProcedure
   {
      public prc_validaperiodo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public prc_validaperiodo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_ParametroDtVigenciaIni ,
                           String aP1_ParametroTipo ,
                           out bool aP2_erro )
      {
         this.AV9ParametroDtVigenciaIni = aP0_ParametroDtVigenciaIni;
         this.AV11ParametroTipo = aP1_ParametroTipo;
         this.AV10erro = false ;
         initialize();
         executePrivate();
         aP2_erro=this.AV10erro;
      }

      public bool executeUdp( DateTime aP0_ParametroDtVigenciaIni ,
                              String aP1_ParametroTipo )
      {
         this.AV9ParametroDtVigenciaIni = aP0_ParametroDtVigenciaIni;
         this.AV11ParametroTipo = aP1_ParametroTipo;
         this.AV10erro = false ;
         initialize();
         executePrivate();
         aP2_erro=this.AV10erro;
         return AV10erro ;
      }

      public void executeSubmit( DateTime aP0_ParametroDtVigenciaIni ,
                                 String aP1_ParametroTipo ,
                                 out bool aP2_erro )
      {
         prc_validaperiodo objprc_validaperiodo;
         objprc_validaperiodo = new prc_validaperiodo();
         objprc_validaperiodo.AV9ParametroDtVigenciaIni = aP0_ParametroDtVigenciaIni;
         objprc_validaperiodo.AV11ParametroTipo = aP1_ParametroTipo;
         objprc_validaperiodo.AV10erro = false ;
         objprc_validaperiodo.context.SetSubmitInitialConfig(context);
         objprc_validaperiodo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprc_validaperiodo);
         aP2_erro=this.AV10erro;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prc_validaperiodo)stateInfo).executePrivate();
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
         AV10erro = false;
         /* Using cursor P000Y2 */
         pr_default.execute(0, new Object[] {AV9ParametroDtVigenciaIni, AV11ParametroTipo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A15ParametroDtVigenciaFim = P000Y2_A15ParametroDtVigenciaFim[0];
            A14ParametroDtVigenciaIni = P000Y2_A14ParametroDtVigenciaIni[0];
            A16ParametroTipo = P000Y2_A16ParametroTipo[0];
            A17ParametroPrioritaria = P000Y2_A17ParametroPrioritaria[0];
            A13ParametroID = P000Y2_A13ParametroID[0];
            AV10erro = true;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
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
         scmdbuf = "";
         P000Y2_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         P000Y2_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         P000Y2_A16ParametroTipo = new String[] {""} ;
         P000Y2_A17ParametroPrioritaria = new String[] {""} ;
         P000Y2_A13ParametroID = new short[1] ;
         A15ParametroDtVigenciaFim = DateTime.MinValue;
         A14ParametroDtVigenciaIni = DateTime.MinValue;
         A16ParametroTipo = "";
         A17ParametroPrioritaria = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prc_validaperiodo__default(),
            new Object[][] {
                new Object[] {
               P000Y2_A15ParametroDtVigenciaFim, P000Y2_A14ParametroDtVigenciaIni, P000Y2_A16ParametroTipo, P000Y2_A17ParametroPrioritaria, P000Y2_A13ParametroID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A13ParametroID ;
      private String AV11ParametroTipo ;
      private String scmdbuf ;
      private String A16ParametroTipo ;
      private String A17ParametroPrioritaria ;
      private DateTime AV9ParametroDtVigenciaIni ;
      private DateTime A15ParametroDtVigenciaFim ;
      private DateTime A14ParametroDtVigenciaIni ;
      private bool AV10erro ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] P000Y2_A15ParametroDtVigenciaFim ;
      private DateTime[] P000Y2_A14ParametroDtVigenciaIni ;
      private String[] P000Y2_A16ParametroTipo ;
      private String[] P000Y2_A17ParametroPrioritaria ;
      private short[] P000Y2_A13ParametroID ;
      private bool aP2_erro ;
   }

   public class prc_validaperiodo__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmP000Y2 ;
          prmP000Y2 = new Object[] {
          new Object[] {"@AV9ParametroDtVigenciaIni",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV11ParametroTipo",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Y2", "SELECT [ParametroDtVigenciaFim], [ParametroDtVigenciaIni], [ParametroTipo], [ParametroPrioritaria], [ParametroID] FROM [Parametro] WHERE ([ParametroDtVigenciaIni] <= @AV9ParametroDtVigenciaIni) AND ([ParametroDtVigenciaFim] >= @AV9ParametroDtVigenciaIni) AND ([ParametroPrioritaria] = 'S') AND ([ParametroTipo] = @AV11ParametroTipo) ORDER BY [ParametroID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Y2,100, GxCacheFrequency.OFF ,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
