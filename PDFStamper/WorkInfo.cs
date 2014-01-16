using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFStamper
{
    class WorkInfo
    {
        public WorkInfo() {
            m_FilesInfo = new Dictionary<string, int>();
            m_TotalWork = 0;
        }
        public Dictionary<string, int> m_FilesInfo;
        public System.Int32 m_TotalWork;
    }
}
