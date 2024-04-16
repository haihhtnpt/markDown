using Xunit;

namespace BSG1.EntityFrameworkCore;

[CollectionDefinition(BSG1TestConsts.CollectionDefinitionName)]
public class BSG1EntityFrameworkCoreCollection : ICollectionFixture<BSG1EntityFrameworkCoreFixture>
{

}
