using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OptimationAPI.Domain.Service.Helper {
    public class XmlHelper {
        public async Task<XmlDocument> LoadXmlDocument(string xml) {
            XmlDocument doc = null;
            try {
                doc = new XmlDocument();
                doc.LoadXml(xml); 
            }
            catch {
                doc = null;
            }
            return doc;
        }
    }
}
