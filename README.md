# ChipChan
ChipChan is a chicken racer Game that is built with Unity 3D The Game shows an adequate incorporation of Ethereum chain in Gamfi. The game utilizes the Moralis SDK and ChainSafe   for User Authentication, NFT MarketPlace, Minting of NFT and Transfer of token to other players. Oknan uses Filecoin/IPFs for storing and retrieving NFT Data and also displaying in-game.Players can view NFTs listed on the ChainSafe marketplace and also purchase NFTs from the marketplace while playing games.

# Creation of NFT WIth IPFS
https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/AppManager.cs
The  UploadToIpfs  function in this class  handles the image Upload to IPFS.
The BuildMetadata function is used to generate metadata for the NFTs.

https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/States/MainPanel.cs
This script retrieves the image from the players device

https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/States/NewAttributePanel.cs

This script is used to create a new attribute for the NFT, it includes the Display_type, Trait_type, and value fields. 

https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/States/ViewAttributesPanel.cs
 With this script you can check out the Attributes that are already created.
 
 #MarketPlace
 The game interacts interact with the chainsafe marketplace, which is still in the Beta stage. The Player’s account must be given approval by the minting interface. The list of minted marketplace items is gotten in the marketplace window. These shows all NFT's that have been minted and have been listed for sale.The player can easily purchase these items in game. We also Provided a way the player can see the list of the NFTs they minted for sale.

Buy NFTs from MarketPlace - (https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/ContractCalls/MarketplaceListedNFT.cs)
Sell NFTs inMarketPlace - https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/ContractCalls/MarketplaceSellNFT.cs
 
  
#Mint NFTs 
Players can Mint NFTs directly to their accounts in ChipChan, they simply provided the CID for the data to be included in the NFTs.
https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/ContractCalls/MintMenu.cs

#Transfer Token
https://github.com/mekuryGlobal/ChipChan/blob/main/Assets/Scripts/ContractCalls/TransferMenu.cs

#Game Demo
https://mekury.itch.io/chio

#Demo Video

https://vimeo.com/750227749
