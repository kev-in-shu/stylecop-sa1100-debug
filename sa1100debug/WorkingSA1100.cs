namespace FailingRuleSA1100
{
    public class WorkingSA1100 : FailSA1100Base<int, int>
    {
        private WorkingSA1100()
            : base("SubClassWithoutOverride")
        {
        }

        public void Test()
        {
            // Warning SA1100 appears on all 3 lines, as expected
            base.Mode = 1;
            base.NoError(@"a");
            base.FullTest(@"a");
        }

        public void Test2()
        {
            // Warning SA1100 appears here, as expected
            base.Mode = 1;
        }
    }
}
