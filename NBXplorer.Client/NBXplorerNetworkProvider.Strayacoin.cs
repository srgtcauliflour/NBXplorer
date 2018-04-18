using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitStrayacoin(ChainType chainType)
		{
			NBitcoin.Altcoins.Straya.EnsureRegistered();
			Add(new NBXplorerNetwork()
			{
				CryptoCode = "NAH",
				MinRPCVersion = 140200,
				NBitcoinNetwork = chainType == ChainType.Main ? NBitcoin.Altcoins.Strayacoin.Mainnet:
								  chainType == ChainType.Test ? NBitcoin.Altcoins.Strayacoin.Testnet :
								  chainType == ChainType.Regtest ? NBitcoin.Altcoins.Strayacoin.Regtest : throw new NotSupportedException(chainType.ToString()),
				DefaultSettings = NBXplorerDefaultSettings.GetDefaultSettings(chainType)
			});
		}

		public NBXplorerNetwork GetNAH()
		{
			return GetFromCryptoCode("NAH");
		}
	}
}
