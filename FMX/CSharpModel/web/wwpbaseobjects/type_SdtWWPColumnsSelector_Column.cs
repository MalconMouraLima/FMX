/*
				   File: type_SdtWWPColumnsSelector_Column
			Description: Columns
				 Author: Nemo 🐠 for C# version 16.0.2.131213
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
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Services.Protocols;

using GeneXus.Programs;
namespace GeneXus.Programs.wwpbaseobjects
{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="WWPColumnsSelector.Column")]
	[XmlType(TypeName="WWPColumnsSelector.Column" , Namespace="FMX" )]
	[Serializable]
	public class SdtWWPColumnsSelector_Column : GxUserType
	{
		public SdtWWPColumnsSelector_Column( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPColumnsSelector_Column_Columnname = "";

		}

		public SdtWWPColumnsSelector_Column(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
				mapper["C"] = "Columnname";
				mapper["V"] = "Isvisible";

			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("C", gxTpr_Columnname, false);


			AddObjectProperty("V", gxTpr_Isvisible, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="ColumnName")]
		[XmlElement(ElementName="ColumnName")]
		public String gxTpr_Columnname
		{
			get { 
				return gxTv_SdtWWPColumnsSelector_Column_Columnname; 
			}
			set { 
				gxTv_SdtWWPColumnsSelector_Column_Columnname = value;
				SetDirty("Columnname");
			}
		}




		[SoapElement(ElementName="IsVisible")]
		[XmlElement(ElementName="IsVisible")]
		public bool gxTpr_Isvisible
		{
			get { 
				return gxTv_SdtWWPColumnsSelector_Column_Isvisible; 
			}
			set { 
				gxTv_SdtWWPColumnsSelector_Column_Isvisible = value;
				SetDirty("Isvisible");
			}
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPColumnsSelector_Column_Columnname = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtWWPColumnsSelector_Column_Columnname;
		 

		protected bool gxTv_SdtWWPColumnsSelector_Column_Isvisible;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPColumnsSelector.Column", Namespace="FMX")]
	public class SdtWWPColumnsSelector_Column_RESTInterface : GxGenericCollectionItem<SdtWWPColumnsSelector_Column>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPColumnsSelector_Column_RESTInterface( ) : base()
		{
		}

		public SdtWWPColumnsSelector_Column_RESTInterface( SdtWWPColumnsSelector_Column psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="C", Order=0)]
		public  String gxTpr_Columnname
		{
			get { 
				return sdt.gxTpr_Columnname;

			}
			set { 
				 sdt.gxTpr_Columnname = value ;
			}
		}

		[DataMember(Name="V", Order=1)]
		public bool gxTpr_Isvisible
		{
			get { 
				return sdt.gxTpr_Isvisible;

			}
			set { 
				sdt.gxTpr_Isvisible = value;
			}
		}


		#endregion

		public SdtWWPColumnsSelector_Column sdt
		{
			get { 
				return (SdtWWPColumnsSelector_Column)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtWWPColumnsSelector_Column() ;
			}
		}
	}
	#endregion
}