namespace FailingRuleSA1100
{
    public abstract class FailSA1100Base<T1, T2>
    {
        protected int Mode { get; set; }

        protected FailSA1100Base(string s)
        {
        }

        protected void FullTest(string filePath)
        {
        }

        protected void TestNoError(string filePath)
        {
        }

        protected void NoError(string filePath)
        {
        }
    }
}
