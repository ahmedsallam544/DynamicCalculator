using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AuthService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertUserDetails( UserDetails userInfo);
        [OperationContract]
        DataSet SelectUserDetails();
        // TODO: Add your service operations here
        [OperationContract]
        int LoginSuccess(string UserName, string Password);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "AuthService.ContractType".
    [DataContract]
    public class UserDetails
    {
        int userid;
        string username;
        string password;
        [DataMember]
        public int UserID {
            get { return userid; }
            set { userid = value; }
        }
        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
