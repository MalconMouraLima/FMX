/*
               File: PRC_AlterarStatus
        Description: Alterar Status do Pedido
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 11:48:20.17
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
   public class prc_alterarstatus : GXProcedure
   {
      public prc_alterarstatus( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public prc_alterarstatus( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_PedidoId ,
                           String aP1_Status )
      {
         this.AV8PedidoId = aP0_PedidoId;
         this.AV9Status = aP1_Status;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_PedidoId ,
                                 String aP1_Status )
      {
         prc_alterarstatus objprc_alterarstatus;
         objprc_alterarstatus = new prc_alterarstatus();
         objprc_alterarstatus.AV8PedidoId = aP0_PedidoId;
         objprc_alterarstatus.AV9Status = aP1_Status;
         objprc_alterarstatus.context.SetSubmitInitialConfig(context);
         objprc_alterarstatus.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprc_alterarstatus);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prc_alterarstatus)stateInfo).executePrivate();
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
         /* Using cursor P00102 */
         pr_default.execute(0, new Object[] {AV8PedidoId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A32PedidoId = P00102_A32PedidoId[0];
            A34PedidoStatus = P00102_A34PedidoStatus[0];
            A34PedidoStatus = AV9Status;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            /* Using cursor P00103 */
            pr_default.execute(1, new Object[] {A34PedidoStatus, A32PedidoId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("Pedido") ;
            if (true) break;
            /* Using cursor P00104 */
            pr_default.execute(2, new Object[] {A34PedidoStatus, A32PedidoId});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("Pedido") ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("prc_alterarstatus",pr_default);
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
         P00102_A32PedidoId = new short[1] ;
         P00102_A34PedidoStatus = new String[] {""} ;
         A34PedidoStatus = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prc_alterarstatus__default(),
            new Object[][] {
                new Object[] {
               P00102_A32PedidoId, P00102_A34PedidoStatus
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8PedidoId ;
      private short A32PedidoId ;
      private String scmdbuf ;
      private String AV9Status ;
      private String A34PedidoStatus ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00102_A32PedidoId ;
      private String[] P00102_A34PedidoStatus ;
   }

   public class prc_alterarstatus__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00102 ;
          prmP00102 = new Object[] {
          new Object[] {"@AV8PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00103 ;
          prmP00103 = new Object[] {
          new Object[] {"@PedidoStatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00104 ;
          prmP00104 = new Object[] {
          new Object[] {"@PedidoStatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00102", "SELECT TOP 1 [PedidoId], [PedidoStatus] FROM [Pedido] WITH (UPDLOCK) WHERE [PedidoId] = @AV8PedidoId ORDER BY [PedidoId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00102,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("P00103", "UPDATE [Pedido] SET [PedidoStatus]=@PedidoStatus  WHERE [PedidoId] = @PedidoId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00103)
             ,new CursorDef("P00104", "UPDATE [Pedido] SET [PedidoStatus]=@PedidoStatus  WHERE [PedidoId] = @PedidoId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00104)
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
