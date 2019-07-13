/*
               File: PRC_CalculaDescFrete
        Description: Calcula o desconto/frete
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:26.0
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
   public class prc_calculadescfrete : GXProcedure
   {
      public prc_calculadescfrete( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public prc_calculadescfrete( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_PedidoDt ,
                           decimal aP1_PedidoTotal ,
                           out decimal aP2_valor )
      {
         this.AV10PedidoDt = aP0_PedidoDt;
         this.AV8PedidoTotal = aP1_PedidoTotal;
         this.AV9valor = 0 ;
         initialize();
         executePrivate();
         aP2_valor=this.AV9valor;
      }

      public decimal executeUdp( DateTime aP0_PedidoDt ,
                                 decimal aP1_PedidoTotal )
      {
         this.AV10PedidoDt = aP0_PedidoDt;
         this.AV8PedidoTotal = aP1_PedidoTotal;
         this.AV9valor = 0 ;
         initialize();
         executePrivate();
         aP2_valor=this.AV9valor;
         return AV9valor ;
      }

      public void executeSubmit( DateTime aP0_PedidoDt ,
                                 decimal aP1_PedidoTotal ,
                                 out decimal aP2_valor )
      {
         prc_calculadescfrete objprc_calculadescfrete;
         objprc_calculadescfrete = new prc_calculadescfrete();
         objprc_calculadescfrete.AV10PedidoDt = aP0_PedidoDt;
         objprc_calculadescfrete.AV8PedidoTotal = aP1_PedidoTotal;
         objprc_calculadescfrete.AV9valor = 0 ;
         objprc_calculadescfrete.context.SetSubmitInitialConfig(context);
         objprc_calculadescfrete.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprc_calculadescfrete);
         aP2_valor=this.AV9valor;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prc_calculadescfrete)stateInfo).executePrivate();
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
         /* Using cursor P00132 */
         pr_default.execute(0, new Object[] {AV10PedidoDt, AV8PedidoTotal});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A18ParametroValor = P00132_A18ParametroValor[0];
            A15ParametroDtVigenciaFim = P00132_A15ParametroDtVigenciaFim[0];
            A14ParametroDtVigenciaIni = P00132_A14ParametroDtVigenciaIni[0];
            A19ParametroPercentual = P00132_A19ParametroPercentual[0];
            A13ParametroID = P00132_A13ParametroID[0];
            AV9valor = (decimal)(AV8PedidoTotal*(A19ParametroPercentual/ (decimal)(100)));
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
         P00132_A18ParametroValor = new decimal[1] ;
         P00132_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         P00132_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         P00132_A19ParametroPercentual = new decimal[1] ;
         P00132_A13ParametroID = new short[1] ;
         A15ParametroDtVigenciaFim = DateTime.MinValue;
         A14ParametroDtVigenciaIni = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prc_calculadescfrete__default(),
            new Object[][] {
                new Object[] {
               P00132_A18ParametroValor, P00132_A15ParametroDtVigenciaFim, P00132_A14ParametroDtVigenciaIni, P00132_A19ParametroPercentual, P00132_A13ParametroID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A13ParametroID ;
      private decimal AV8PedidoTotal ;
      private decimal AV9valor ;
      private decimal A18ParametroValor ;
      private decimal A19ParametroPercentual ;
      private String scmdbuf ;
      private DateTime AV10PedidoDt ;
      private DateTime A15ParametroDtVigenciaFim ;
      private DateTime A14ParametroDtVigenciaIni ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] P00132_A18ParametroValor ;
      private DateTime[] P00132_A15ParametroDtVigenciaFim ;
      private DateTime[] P00132_A14ParametroDtVigenciaIni ;
      private decimal[] P00132_A19ParametroPercentual ;
      private short[] P00132_A13ParametroID ;
      private decimal aP2_valor ;
   }

   public class prc_calculadescfrete__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00132 ;
          prmP00132 = new Object[] {
          new Object[] {"@AV10PedidoDt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8PedidoTotal",SqlDbType.Decimal,12,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00132", "SELECT [ParametroValor], [ParametroDtVigenciaFim], [ParametroDtVigenciaIni], [ParametroPercentual], [ParametroID] FROM [Parametro] WHERE ([ParametroDtVigenciaIni] <= @AV10PedidoDt) AND ([ParametroDtVigenciaFim] >= @AV10PedidoDt) AND ([ParametroValor] <= @AV8PedidoTotal) ORDER BY [ParametroID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00132,100, GxCacheFrequency.OFF ,false,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
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
                stmt.SetParameter(2, (decimal)parms[1]);
                return;
       }
    }

 }

}
