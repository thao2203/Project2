namespace Bai11_102_giaotrinh
{
    internal class XmlTextWrite
    {
        private string v;
        private object p;

        public XmlTextWrite(string v, object p)
        {
            this.v = v;
            this.p = p;
        }

        public object xmlText { get; internal set; }
    }
}