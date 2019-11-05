using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelBookingService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Room> getRooms();

        [OperationContract]
        int[] getRoomNos(int rt);

        [OperationContract]
        int bookRoom(string n, string p, string e, int rno, string indt, string outdt);

        [OperationContract]
        int getCustomerId(string nm, string ph, string em);

        [OperationContract]
        List<Booked> getBookingInfo(int id);
        
        [OperationContract]
        bool isRoomBooked(int rno);

        [OperationContract]
        void cancelBooking(int bid);

        [OperationContract]
        void updateBookingDate(int bid, string indt, string outdt);
    }
    [DataContract]
    public class Booked
    {
        private int id;
        private int cid;
        private int rnos;
        private string indate;
        private string outdate;
        private int amt;
        private int days;

        [DataMember]
        public int BID
        {
            get { return id; }
            set { this.id = value; }
        }
        [DataMember]
        public int CID
        {
            get { return cid; }
            set { this.cid = value; }
        }
        [DataMember]
        public int RoomNos
        {
            get { return rnos; }
            set { this.rnos = value; }
        }
        [DataMember]
        public string CheckInDate
        {
            get { return indate; }
            set { this.indate = value; }
        }
        [DataMember]
        public string CheckOutDate
        {
            get { return outdate; }
            set { this.outdate = value; }
        }
        [DataMember]
        public int TotalAmount
        {
            get { return amt; }
            set { this.amt = value; }
        }
        [DataMember]
        public int TotalDays
        {
            get { return days; }
            set { this.days = value; }
        }
    }

    [DataContract]
    public class Room
    {
        private int no;
        private string type;
        private int price;
        private int occupacy;
        private string isbooked;

        [DataMember]
        public int RoomNo
        {
            get { return no; }
            set { this.no = value; }
        }
        [DataMember]
        public string RType
        {
            get { return type; }
            set { this.type = value; }
        }
        [DataMember]
        public int RPrice
        {
            get { return price; }
            set { this.price = value; }
        }
        [DataMember]
        public int Occupacy
        {
            get { return occupacy; }
            set { this.occupacy = value; }
        }
        [DataMember]
        public string IsBooked
        {
            get { return isbooked; }
            set { this.isbooked = value; }
        }
    }

    [DataContract]
    public class Customer
    {
        private int cid;
        private string cname;
        private string phone;
        private string email;

        [DataMember]
        public int CID
        {
            get { return cid; }
            set { this.cid = value; }
        }
        [DataMember]
        public string CName
        {
            get { return cname; }
            set { this.cname = value; }
        }
        [DataMember]
        public string CPhone
        {
            get { return phone; }
            set { this.phone = value; }
        }
        [DataMember]
        public string CEmail
        {
            get { return email; }
            set { this.email = value; }
        }
    }

}

