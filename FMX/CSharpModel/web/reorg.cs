/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 12:50:10.65
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public reorg( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void ReorganizePedido( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Pedido */
         cmdBuffer=" ALTER TABLE [Pedido] ADD [PedidoDescontoFrete]  money NOT NULL CONSTRAINT PedidoDescontoFretePedido_DEFAULT DEFAULT convert(int, 0), [PedidoTotal]  money NOT NULL CONSTRAINT PedidoTotalPedido_DEFAULT DEFAULT convert(int, 0) "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE [Pedido] DROP CONSTRAINT PedidoDescontoFretePedido_DEFAULT "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" UPDATE [Pedido] SET [PedidoTotal]=T.[PedidoTotal] FROM (SELECT T1.[PedidoId], COALESCE( T2.[PedidoTotal], 0) AS PedidoTotal FROM ([Pedido] T1 LEFT JOIN (SELECT COALESCE( T4.[GXC1], 0) AS PedidoTotal, T3.[PedidoId] FROM ([Pedido] T3 LEFT JOIN (SELECT SUM(T6.[ProdutoValor] * CAST(T5.[PedidoItemQtd] AS decimal( 22, 10))) AS GXC1, T5.[PedidoId] FROM ([PedidoItem] T5 INNER JOIN [Produto] T6 ON T6.[ProdutoId] = T5.[ProdutoId]) GROUP BY T5.[PedidoId] ) T4 ON T4.[PedidoId] = T3.[PedidoId]) ) T2 ON T2.[PedidoId] = T1.[PedidoId])) T WHERE [Pedido].PedidoId= T.PedidoId "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE [Pedido] DROP CONSTRAINT PedidoTotalPedido_DEFAULT "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00034 */
            pr_default.execute(0);
            PedidoCount = P00034_APedidoCount[0];
            pr_default.close(0);
            PrintRecordCount ( "Pedido" ,  PedidoCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00045 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00045_AsSchemaVar[0];
               nsSchemaVar = P00045_nsSchemaVar[0];
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         else
         {
            /* Using cursor P00056 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               sSchemaVar = P00056_AsSchemaVar[0];
               nsSchemaVar = P00056_nsSchemaVar[0];
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         if ( ColumnExist("Pedido",sSchemaVar,"PedidoDescontoFrete") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"PedidoDescontoFrete", "Pedido"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool ColumnExist( String sTableName ,
                                String sMySchemaName ,
                                String sMyColumnName )
      {
         bool result ;
         result = false;
         /* Using cursor P00067 */
         pr_default.execute(3, new Object[] {sTableName, sMySchemaName, sMyColumnName});
         while ( (pr_default.getStatus(3) != 101) )
         {
            tablename = P00067_Atablename[0];
            ntablename = P00067_ntablename[0];
            schemaname = P00067_Aschemaname[0];
            nschemaname = P00067_nschemaname[0];
            columnname = P00067_Acolumnname[0];
            ncolumnname = P00067_ncolumnname[0];
            result = true;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "ReorganizePedido" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Pedido", ""}) );
      }

      private void SetPrecedenceris( )
      {
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00034_APedidoCount = new int[1] ;
         sSchemaVar = "";
         nsSchemaVar = false;
         P00045_AsSchemaVar = new String[] {""} ;
         P00045_nsSchemaVar = new bool[] {false} ;
         P00056_AsSchemaVar = new String[] {""} ;
         P00056_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         sMySchemaName = "";
         sMyColumnName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         columnname = "";
         ncolumnname = false;
         P00067_Atablename = new String[] {""} ;
         P00067_ntablename = new bool[] {false} ;
         P00067_Aschemaname = new String[] {""} ;
         P00067_nschemaname = new bool[] {false} ;
         P00067_Acolumnname = new String[] {""} ;
         P00067_ncolumnname = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00034_APedidoCount
               }
               , new Object[] {
               P00045_AsSchemaVar
               }
               , new Object[] {
               P00056_AsSchemaVar
               }
               , new Object[] {
               P00067_Atablename, P00067_Aschemaname, P00067_Acolumnname
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int PedidoCount ;
      protected String scmdbuf ;
      protected String sSchemaVar ;
      protected String sTableName ;
      protected String sMySchemaName ;
      protected String sMyColumnName ;
      protected bool nsSchemaVar ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool ncolumnname ;
      protected String tablename ;
      protected String schemaname ;
      protected String columnname ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00034_APedidoCount ;
      protected String[] P00045_AsSchemaVar ;
      protected bool[] P00045_nsSchemaVar ;
      protected String[] P00056_AsSchemaVar ;
      protected bool[] P00056_nsSchemaVar ;
      protected String[] P00067_Atablename ;
      protected bool[] P00067_ntablename ;
      protected String[] P00067_Aschemaname ;
      protected bool[] P00067_nschemaname ;
      protected String[] P00067_Acolumnname ;
      protected bool[] P00067_ncolumnname ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          } ;
          Object[] prmP00045 ;
          prmP00045 = new Object[] {
          } ;
          Object[] prmP00056 ;
          prmP00056 = new Object[] {
          } ;
          Object[] prmP00067 ;
          prmP00067 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0} ,
          new Object[] {"@sMySchemaName",SqlDbType.Char,255,0} ,
          new Object[] {"@sMyColumnName",SqlDbType.Char,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00034", "SELECT COUNT(*) FROM [Pedido] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00045", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00056", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00056,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00067", "SELECT TABLE_NAME, TABLE_SCHEMA, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE (TABLE_NAME = @sTableName) AND (TABLE_SCHEMA = @sMySchemaName) AND (COLUMN_NAME = @sMyColumnName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00067,100, GxCacheFrequency.OFF ,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
       }
    }

 }

}
