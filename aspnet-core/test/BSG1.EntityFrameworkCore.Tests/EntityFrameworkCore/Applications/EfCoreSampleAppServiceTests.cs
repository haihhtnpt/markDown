using BSG1.Samples;
using Xunit;

namespace BSG1.EntityFrameworkCore.Applications;

[Collection(BSG1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BSG1EntityFrameworkCoreTestModule>
{

}
