using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFStamper
{
    class WorkStep
    {
        public WorkStep()
        {
            m_StateMessage = System.String.Empty;
            m_ProgressPercentage = 0;
            m_ShowMessage = true;
        }

        public System.String m_StateMessage;
        public System.Int32 m_ProgressPercentage;
        public System.Boolean m_ShowMessage;
    }
}
