using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace redifyservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        long FibonacciNumber(long n);

        [OperationContract]
        string ReverseWords(string s);

        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

    }
    public enum TriangleType { Equilateral, Error, Isosceles, Scalene };
}
