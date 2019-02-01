namespace FailingRuleSA1100
{
    public class FailSA1100 : FailSA1100Base<int, int>
    {
        private FailSA1100()
            : base("SubClassWithoutOverride")
        {
        }

        public void Init()
        {
            // There should be a Warning SA1100 here
            base.Mode = 1;

            // 2 issues with the line that invokes TestNoError,
            //   * the rule stops triggering on property Mode in the whole file
            //   * the rule does not work on this line itself
            // Comment the line to see warnings appear on the Mode property usage
            base.TestNoError(@"a");
            base.NoError(@"a");
            base.FullTest(@"a");
        }

        public void Pass()
        {
            // There should be a Warning SA1100 here
            base.Mode = 1;
        }
    }
}
