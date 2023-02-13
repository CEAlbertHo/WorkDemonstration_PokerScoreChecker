using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShuffleUtil;

namespace Poker
{
     // 牌組生成
    public class DeckBuilder
    {
        public const int cPokerType_Min = 1;
        public const int cPokerType_Max = 52;

        public static CardDeck BuildStandardDeck( bool iIsShuffle = true )
        {
            List<Card> cards = new();
            for( int type = cPokerType_Min; type <= cPokerType_Max; type++ )
            {
                Card card = new( type );
                cards.Add( card );
            }

            CardDeck deck = new()
            {
                Cards = cards
            };

            if( iIsShuffle )
                deck.Shuffle();

            return deck;
        }
    }

    // 牌堆
    public class CardDeck
    {
        public List<Card> Cards;

        public CardDeck()
        {
            Cards = new();
        }

        public void Shuffle( int iShuffleCount = 1 )
        {
            if( iShuffleCount <= 0 )
                return;

            for( int i = 0; i < iShuffleCount; i++ )
                Cards.Shuffle();

            Debug.Log( "--- Deck Shuffle Done ---" );
        }

        public void DealCardFromTop( CardDeck iTarget, int iDealNum = 1 )
        {
            if( iTarget == null )
                return;
            if( iDealNum <= 0 )
                return;
            if( Cards.Count <= iDealNum )
                return;

            for( int i = 0; i < iDealNum; i++ )
            {
                Card firstCard = Cards[ 0 ];
                Cards.RemoveAt( 0 );
                iTarget.ReceiveCard( firstCard );
            }
        }

        public void ReceiveCard( Card iReceivedCard )
        {
            if( iReceivedCard == null )
                return;

            Cards.Add( iReceivedCard );
        }

        public void AddOneSetOfDeck()
        {
            CardDeck newDeck = DeckBuilder.BuildStandardDeck( false );
            Cards.AddRange( newDeck.Cards );
        }

        public void Debug_LogNowCards()
        {
            string log = Newtonsoft.Json.JsonConvert.SerializeObject( Cards );
            Debug.Log( log );
        }
    }
}