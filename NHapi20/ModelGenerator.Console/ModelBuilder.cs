using System;
using System.Configuration;
using NHapi.Base.Standard;
using NHapi.Base.Standard.SourceGeneration;
using ConfigurationSettings = NHapi.Base.ConfigurationSettings;

namespace ModelGenerator.Standard
{
   public class ModelBuilder
   {
	  public enum MessageType
	  {
		 All,
		 Message,
		 Segment,
		 DataType,
		 EventMapping
	  }

	  public ModelBuilder()
	  {
		 this.BasePath = @"C:\Development\nhapi\output";
		 this.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
		 this.MessageTypeToBuild = MessageType.All;
	  }

	  public string BasePath { get; set; }

      public string Version { get; set; } = "2.4";

      public string ConnectionString { get; set; }

	  public MessageType MessageTypeToBuild { get; set; }

	  public void Execute()
	  {
		 if (!string.IsNullOrEmpty(this.ConnectionString))
		 {
			ConfigurationSettings.ConnectionString = this.ConnectionString;
		 }

		 Console.WriteLine("Using Database:{0}", NormativeDatabase.Instance.Connection.ConnectionString);
		 Console.WriteLine("Base Path:{0}", this.BasePath);

		 switch (this.MessageTypeToBuild)
		 {
			case MessageType.All:
			   SourceGenerator.makeAll(this.BasePath, this.Version);
			   break;
			case MessageType.EventMapping:
			   SourceGenerator.MakeEventMapping(this.BasePath, this.Version);
			   break;
			case MessageType.Segment:
			   SegmentGenerator.makeAll(this.BasePath, this.Version);
			   break;
			case MessageType.Message:
			   MessageGenerator.makeAll(this.BasePath, this.Version);
			   break;
			case MessageType.DataType:
			   DataTypeGenerator.makeAll(this.BasePath, this.Version);
			   break;
		 }
	  }
   }
}