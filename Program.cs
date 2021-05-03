using System;
using System.IO;
using System.Xml;
using System.Globalization;
using System.Data;
using System.Linq;

namespace ConsoleApplication.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //getFilePath();
            //string strDate=ParseActionByDate("2021-01-12");
            //string strfinalActionByDate = DetermineActionByDate(strDate, "Update");
            //GetUnixFilePathfromString("/apps/wi-x/fileshare/PP/ManualIndexing/Outbound/308.1/800000059940_1998_20180321193009000.TIFF.PDF");
            //string value1 = ChangeDateFormat("2020/10/10 10:00:00", "yyyy/MM/dd HH:mm:ss", "yyyy-MM-ddTHH:mm:ss");
            //GetUnixFilePath("apps/wi-x/fileshare/dv/Attachments/Outbound","ABC0001.pdf");
            //XmlDocument ErrorGenericResp = new XmlDocument();
            //ErrorGenericResp.Load("C:\\Ravi\\MRP_DCMS\\Reindexing\\ErrorOWCGenericResponse.xml");
            //bool indicator =checkStatusCodeinGenericRespXml(ErrorGenericResp);
            //XmlDocument paylod = new XmlDocument();
            //paylod= setActvityCommentsNode(" trasaction1");
            //string outvalue12=GetReferenceDataValue("ChannelSource","WIX", "DCDS", "Canonical",true);
            //isstringAvailable();
            //editxml();
            EncodeTo64();
        }
        static void getFilePath()
        {
            string strFilepath = @"C:\AIBP\ManualIndexing\Inbound";
            string suffix = DateTime.Now.ToString("fff");
            string strFilename = "TestFile0001.pdf";
            string CombinedFilename = Path.Combine(strFilepath, strFilename);
        }
        public static string GetUnixFilePath(string strFilePath, string strFileName)
        {
            string strReturn = System.String.Empty;
            strReturn = System.IO.Path.Combine(strFilePath, strFileName);
            strReturn = strReturn.Replace("\\", "/");
            return strReturn;
        }
        public static string GetUnixFilePathfromString(string strFilePath)
        {
            string strReturn = System.String.Empty;
            strFilePath = strFilePath.Replace("/","\\");
            strReturn = System.IO.Path.GetFileName(strFilePath);
            strReturn = strReturn.Replace("\\", "/");
            return strReturn;
        }
        public static string ChangeDateFormat(string dateString, string inputFormat, string outputFormat)
        {
            DateTime tempDate;
            //IFormatProvider culture = new System.Globalization.CultureInfo("en-EN", true);

            tempDate = DateTime.ParseExact(dateString, inputFormat, CultureInfo.InvariantCulture);
            string outDate = tempDate.ToString(outputFormat);

            return outDate;
        }
        public static bool checkStatusCodeinGenericRespXml(XmlDocument canonicalPayload)
        {
            bool indicator = false;
            XmlNode StatusCodeNode = canonicalPayload.SelectSingleNode("/*[local-name()='GenericResponse' and namespace-uri()='http://www.oracle.com/UCM']/*[local-name()='Service' and namespace-uri()='http://www.oracle.com/UCM']/*[local-name()='Document' and namespace-uri()='http://www.oracle.com/UCM']/*[local-name()='Field' and namespace-uri()='http://www.oracle.com/UCM'][@name='StatusCode']");
            //XmlNode StatusCodeNodeValue = canonicalPayload.SelectSingleNode("string(/*[local-name()='GenericResponse' and namespace-uri()='http://www.oracle.com/UCM']/*[local-name()='Service' and namespace-uri()='http://www.oracle.com/UCM']/*[local-name()='Document' and namespace-uri()='http://www.oracle.com/UCM']/*[local-name()='Field' and namespace-uri()='http://www.oracle.com/UCM'][@name='StatusCode'])");
            //string strvalue= StatusCodeNode.InnerText;
            //int value = Convert.ToInt32(strvalue);
            if (StatusCodeNode != null && Convert.ToInt32(StatusCodeNode.InnerText) != 0)
            {
                indicator = true;
            }
            return indicator;
        }

        public static XmlDocument setActvityCommentsNode(string strTransactionID)
        {
            XmlDocument canonicalPayload = new XmlDocument();
            canonicalPayload.Load(@"C:\Ravi\Demo\Samples\AIBPCanonical.xml");
         XmlNodeList ListCommentNode = canonicalPayload.SelectNodes("/*[local-name()='AIBPCanonical' and namespace-uri()='urn:dxc.esb.aibp.canonical/v1']/*[local-name()='Control' and namespace-uri()='urn:dxc.esb.aibp.canonical/v1']/*[local-name()='QueryResults' and namespace-uri()='urn:dxc.esb.aibp.canonical/v1']/*[local-name()='SLS' and namespace-uri()='urn:dxc.esb.aibp.canonical/v1']/*[local-name()='Activity' and namespace-uri()='urn:dxc.esb.aibp.canonical/v1']/*[local-name()='Comments' and namespace-uri()='urn:dxc.esb.aibp.canonical/v1']");
            foreach(XmlNode commentNode in ListCommentNode)
            {
                commentNode.InnerText = "ABC"+strTransactionID;
            }
            
            return canonicalPayload;
        }
        public static string ParseActionByDate(string date)
        {
            System.DateTime actionByDate = DateTime.Parse(date, new System.Globalization.CultureInfo("en-AU", false));

            return actionByDate.ToString("yyyy-MM-ddTHH:mm:sszzz");
        }
        public static string DetermineActionByDate(string currentActionByDate, string SLSOperation)
        {
            bool ActionByDateDetermine;
        DateTime DeterminedActionByDate = DateTime.Parse(currentActionByDate);
        //List<DateTime> holidayList = DBFactHelper.GetPublicHolidays();

            
            

            if (SLSOperation == "Update")
            {
                if (DeterminedActionByDate.Date != DateTime.Today.Date)
                {
                    int dateComparisonResult = DeterminedActionByDate.Date.CompareTo(DateTime.Today.Date);

                    //If the date comparision yields a positive value, means the DetermindedActionByDate
                    //is in future. So according to logic, we reset the value of DeterminedActionByDate to System Date

                    if (dateComparisonResult > 0 || dateComparisonResult< 0)
                    {
                        DeterminedActionByDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));
                    }
                  
                    do
                    {
                        ActionByDateDetermine = false;
                        DeterminedActionByDate = DeterminedActionByDate.AddDays(1);

                        if (DeterminedActionByDate.DayOfWeek == System.DayOfWeek.Saturday || DeterminedActionByDate.DayOfWeek == System.DayOfWeek.Sunday)
                        {
                            ActionByDateDetermine = true;
                        }

                        //foreach (DateTime holiday in holidayList)
                        //{
                        //    if (holiday.Date == DeterminedActionByDate.Date)
                        //    {
                        //        ActionByDateDetermine = true;
                        //    }
                        //}

                    } while (ActionByDateDetermine);
                }
            }

            return DeterminedActionByDate.ToString("yyyy-MM-ddTHH:mm:sszzz");
        }
        public static string GetReferenceDataValue(string category, string inputField, string inputValue, string outputField, bool caseSensitive)
        {
            DataSet Mappings = new DataSet();
            //Log the input parameter values
            //logger.DebugFormat("ReferenceDataHelper::GetReferenceDataValue: Query for Category '{0}', inputfield '{1}', input value '{2}', outputfield '{3}', caseSensitive '{4}'.", category, inputField, inputValue, outputField, caseSensitive);

            StringComparer comparer = caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;

            bool match = comparer.Equals("Category", category);

            // Try and find the item
            var rows = Mappings.Tables["Mapping"].AsEnumerable().Where(
                         x => comparer.Equals(x.Field<string>("Category"), category) &&
                              comparer.Equals(x.Field<string>(inputField), inputValue));

            //Log the result values
            //logger.DebugFormat("ReferenceDataHelper::GetReferenceDataValue: Number of rows in result '{0}'.", rows.Count().ToString());

            // One item found
            var rowcout = rows.Count();
            
                var row = rows.ElementAt(0);

                //logger.DebugFormat("ReferenceDataHelper::GetReferenceDataValue: Output result '{0}'.", row.Field<string>(outputField));
               // return row.Field<string>(outputField);
            

            // No items found

            return row.Field<string>(outputField);
            // More than one item found - should not be possible unless there is bad data
            //logger.WarnFormat("ReferenceDataHelper::GetReferenceDataValue: TooMuchDataFoundError for Category '{0}', inputfield '{1}', input value '{2}', outputfield '{3}', caseSensitive '{4}'.", category, inputField, inputValue, outputField, caseSensitive);

        }
        public static void isstringAvailable()
        {
            string[] liststring =
            {
                "Private Bank Servicing",
                "Credit Referral",
                "Progress Draw",
                "Document Capture"
            };
         bool boolValue=   liststring.Contains("Document Capture");
        }

        public static void editxml()
        {
            XmlDocument canonicalPayload = new XmlDocument();
            canonicalPayload.Load(@"C:\Users\Administrator\Downloads\samplexml.xml");
            XmlElement element = null;
            
            
            XmlNode editNode = canonicalPayload.SelectSingleNode("/*[local-name()='Collection' and namespace-uri()='urn:dxc.esb.aibp.provider/v1']/*[local-name()='detail' and namespace-uri()='urn:dxc.esb.aibp.provider/v1']");
            XmlNode addnode = null;

            //XmlWriter wr = new XmlWriter();
            //wr.WriteElementString("filename", "value");
        }
        public static void EncodeTo64()

        {
            string stringToEncode = @"C:\AIBP\WIX\Attachments\Inbound\df0bbb73-875c-45ce-b35e-a8cf0d3e1d95_1.pdf";

           // byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(stringToEncode);
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(stringToEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);

           // toEncodeAsBytes=System.Text.Encoding.UTF8.GetBytes(returnValue);

            toEncodeAsBytes = System.Convert.FromBase64String(returnValue);

            string getString = System.Text.ASCIIEncoding.ASCII.GetString(toEncodeAsBytes);

            string path = System.IO.Path.GetDirectoryName(getString);
            path= System.IO.Path.GetFileName(getString);
            

            // return returnValue;
            
        }
        public string ConvertBase64ToString(string base64string)
        {
            byte[] b = System.Convert.FromBase64String(base64string);
            string fullname = System.Text.ASCIIEncoding.ASCII.GetString(b);

            string filepath = System.IO.Path.GetDirectoryName(fullname);
            string filename= System.IO.Path.GetFileNameWithoutExtension(fullname);
            filename = filename.Replace("_1", "");
           
            return System.IO.Path.Combine(filepath, string.Concat("DXC_", filename, ".xml"));

        }
    }
}
