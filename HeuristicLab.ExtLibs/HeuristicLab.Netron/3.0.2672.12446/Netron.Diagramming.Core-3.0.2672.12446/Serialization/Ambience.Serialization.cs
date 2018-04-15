using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Schema;
using System.Xml.Serialization;
namespace Netron.Diagramming.Core {
  /// <summary>
  /// Complementary partial class related to (de)serialization.
  /// </summary>
  [Serializable]
  public partial class Ambience : ISerializable, IXmlSerializable, IDeserializationCallback {
    //about xml serialization of color
    //http://dotnetified.com/PermaLink.aspx?guid=E86B447E-AA95-49B6-909F-CDA36ACF481F

    #region Deserialization constructor
    /// <summary>
    /// Deserialization constructor
    /// </summary>
    /// <param name="info">The info.</param>
    /// <param name="context">The context.</param>
    protected Ambience(SerializationInfo info, StreamingContext context) {
      if (Tracing.BinaryDeserializationSwitch.Enabled)
        Trace.WriteLine("Deserializing the fields of 'Ambience'.");

      double version = info.GetDouble("AmbienceVersion");
      this.BackgroundColor = (Color)info.GetValue("BackgroundColor", typeof(Color));
      this.PageColor = (Color)info.GetValue("PageBackgroundColor", typeof(Color));
    }
    #endregion

    #region Serialization events
    /*
        [OnSerializing]
        void OnSerializing(StreamingContext context)
        {
            Trace.Indent();
            Trace.WriteLine("Starting to serializing the 'Ambience' class...");
        }
        [OnSerialized]
        void OnSerialized(StreamingContext context)
        {
            Trace.WriteLine("...serialization of 'Ambience' finished");
            Trace.Unindent();
        }
        */
    #endregion

    #region Deserialization events
    /*
        [OnDeserializing]
        void OnDeserializing(StreamingContext context)
        {
            Trace.Indent();
            Trace.WriteLine("Starting deserializing the 'Ambience' class...");
        }
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
         {
             Trace.WriteLine("...deserialization of 'Ambience' finished");
             Trace.Unindent();
         }
        */
    #endregion

    #region Serialization
    /// <summary>
    /// Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> with the data needed to serialize the target object.
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data.</param>
    /// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization.</param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {
      if (Tracing.BinarySerializationSwitch.Enabled)
        Trace.WriteLine("Serializing the fields of 'Ambience'.");

      info.AddValue("AmbienceVersion", ambienceVersion);

      info.AddValue(
          "BackgroundColor",
          this.BackgroundColor,
          typeof(Color));

      info.AddValue(
          "BackgroundType",
          BackgroundType,
          typeof(CanvasBackgroundTypes));

      info.AddValue(
          "BackgroundGradientColor1",
          this.BackgroundGradientColor1,
          typeof(Color));

      info.AddValue(
          "BackgroundGradientColor2",
          this.BackgroundGradientColor2,
          typeof(Color));

      info.AddValue(
          "PageBackgroundColor",
          this.PageColor,
          typeof(Color));

      info.AddValue(
          "PageBackgroundType",
          PageBackgroundType,
          typeof(CanvasBackgroundTypes));

      info.AddValue(
          "PageBackgroundGradientColor1",
          this.PageGradientColor1,
          typeof(Color));

      info.AddValue(
          "PageBackgroundGradientColor2",
          this.PageGradientColor2,
          typeof(Color));
    }
    #endregion

    #region Xml serialization
    /// <summary>
    /// This property is reserved, apply the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute"></see> to the class instead.
    /// </summary>
    /// <returns>
    /// An <see cref="T:System.Xml.Schema.XmlSchema"></see> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)"></see> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)"></see> method.
    /// </returns>
    public XmlSchema GetSchema() {
      throw new NotImplementedException("The method or operation is not implemented.");
    }

    /// <summary>
    /// Generates an object from its XML representation.
    /// </summary>
    /// <param name="reader">The <see cref="T:System.Xml.XmlReader"></see> stream from which the object is deserialized.</param>
    public void ReadXml(System.Xml.XmlReader reader) {
      throw new NotImplementedException("The method or operation is not implemented.");
    }

    /// <summary>
    /// Converts an object into its XML representation.
    /// </summary>
    /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"></see> stream to which the object is serialized.</param>
    public void WriteXml(System.Xml.XmlWriter writer) {
      throw new NotImplementedException("The method or operation is not implemented.");
    }
    #endregion

    #region IDeserializationCallback Members

    /// <summary>
    /// Runs when the entire object graph has been deserialized.
    /// </summary>
    /// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
    public void OnDeserialization(object sender) {
      if (Tracing.BinaryDeserializationSwitch.Enabled)
        Trace.WriteLine("IDeserializationCallback of 'Ambience' called.");
    }

    #endregion
  }
}
