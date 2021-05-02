using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;


namespace WcfMouceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool Authorization(string log, string pas);

        [OperationContract]
        void Insert(MouseEv mouse);

        [OperationContract]
        DataTable LoadFromDB();

        [OperationContract]
        GetEventData GetInfo();


    }

    [DataContract]
    public class GetEventData
    {
        [DataMember]
        public DataTable EventTable { get; set; }
    }

    [DataContract]
    public class MouseEv
    {
        DateTime date;
        string mouseEvent = string.Empty;
        string coordinate = string.Empty;

        [DataMember]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        [DataMember]
        public string MouseEvent
        {
            get { return mouseEvent; }
            set { mouseEvent = value; }
        }
        [DataMember]
        public string Coordinate
        {
            get { return coordinate; }
            set { coordinate = value; }
        }
    }
}
