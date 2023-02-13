using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Poker
{
    // 花色
    public enum EPokerSuit : int
    {
        Spades   = 4,
        Hearts   = 3,
        Diamonds = 2,
        Clubs    = 1,
    }

    // 牌階
    public enum EPokerRank : int
    {
        Number2  = 1,
        Number3  = 2,
        Number4  = 3,
        Number5  = 4,
        Number6  = 5,
        Number7  = 6,
        Number8  = 7,
        Number9  = 8,
        Number10 = 9,
        Jack     = 10,
        Queen    = 11,
        King     = 12,
        Ace      = 13,
    }

    // 撲克牌種類
    public enum EPokerCardType
    {
        // Clubs
        C2  = 1,
        C3  = 2,
        C4  = 3,
        C5  = 4,
        C6  = 5,
        C7  = 6,
        C8  = 7,
        C9  = 8,
        C10 = 9,
        CJ  = 10,
        CQ  = 11,
        CK  = 12,
        CA  = 13,

        // Diamonds
        D2  = 14,
        D3  = 15,
        D4  = 16,
        D5  = 17,
        D6  = 18,
        D7  = 19,
        D8  = 20,
        D9  = 21,
        D10 = 22,
        DJ  = 23,
        DQ  = 24,
        DK  = 25,
        DA  = 26,

        // Hearts
        H2  = 27,
        H3  = 28,
        H4  = 29,
        H5  = 30,
        H6  = 31,
        H7  = 32,
        H8  = 33,
        H9  = 34,
        H10 = 35,
        HJ  = 36,
        HQ  = 37,
        HK  = 38,
        HA  = 39,

        // Spades
        S2  = 40,
        S3  = 41,
        S4  = 42,
        S5  = 43,
        S6  = 44,
        S7  = 45,
        S8  = 46,
        S9  = 47,
        S10 = 48,
        SJ  = 49,
        SQ  = 50,
        SK  = 51,
        SA  = 52,

        // Special
        Joker,
    }

    // 撲克牌資訊
    public class CardInfo
    {
        public int Suit;
        public int Rank;

        public CardInfo( int iSuit, int iRank )
        {
            Suit = iSuit;
            Rank = iRank;
        }

        public string GetInfoStr()
        {
            return $"{ (EPokerSuit)Suit }-{ (EPokerRank)Rank }";
        }
    }

    // 撲克牌資料容器
    public class CardDataHolder
    {
        private static readonly Dictionary<int, CardInfo> CardInfoDic = new Dictionary<int, CardInfo>()
        {
            // Clubs
            [ (int)EPokerCardType.C2 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number2 ),
            [ (int)EPokerCardType.C3 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number3 ),
            [ (int)EPokerCardType.C4 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number4 ),
            [ (int)EPokerCardType.C5 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number5 ),
            [ (int)EPokerCardType.C6 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number6 ),
            [ (int)EPokerCardType.C7 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number7 ),
            [ (int)EPokerCardType.C8 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number8 ),
            [ (int)EPokerCardType.C9 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number9 ),
            [ (int)EPokerCardType.C10 ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Number10 ),
            [ (int)EPokerCardType.CJ  ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Jack ),
            [ (int)EPokerCardType.CQ  ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Queen ),
            [ (int)EPokerCardType.CK  ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.King ),
            [ (int)EPokerCardType.CA  ] = new CardInfo( (int)EPokerSuit.Clubs, (int)EPokerRank.Ace ),

            // Diamonds
            [ (int)EPokerCardType.D2 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number2 ),
            [ (int)EPokerCardType.D3 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number3 ),
            [ (int)EPokerCardType.D4 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number4 ),
            [ (int)EPokerCardType.D5 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number5 ),
            [ (int)EPokerCardType.D6 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number6 ),
            [ (int)EPokerCardType.D7 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number7 ),
            [ (int)EPokerCardType.D8 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number8 ),
            [ (int)EPokerCardType.D9 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number9 ),
            [ (int)EPokerCardType.D10 ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Number10 ),
            [ (int)EPokerCardType.DJ  ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Jack ),
            [ (int)EPokerCardType.DQ  ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Queen ),
            [ (int)EPokerCardType.DK  ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.King ),
            [ (int)EPokerCardType.DA  ] = new CardInfo( (int)EPokerSuit.Diamonds, (int)EPokerRank.Ace ),

            // Hearts
            [ (int)EPokerCardType.H2 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number2 ),
            [ (int)EPokerCardType.H3 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number3 ),
            [ (int)EPokerCardType.H4 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number4 ),
            [ (int)EPokerCardType.H5 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number5 ),
            [ (int)EPokerCardType.H6 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number6 ),
            [ (int)EPokerCardType.H7 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number7 ),
            [ (int)EPokerCardType.H8 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number8 ),
            [ (int)EPokerCardType.H9 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number9 ),
            [ (int)EPokerCardType.H10 ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Number10 ),
            [ (int)EPokerCardType.HJ  ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Jack ),
            [ (int)EPokerCardType.HQ  ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Queen ),
            [ (int)EPokerCardType.HK  ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.King ),
            [ (int)EPokerCardType.HA  ] = new CardInfo( (int)EPokerSuit.Hearts, (int)EPokerRank.Ace ),

            // Spades
            [ (int)EPokerCardType.S2 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number2 ),
            [ (int)EPokerCardType.S3 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number3 ),
            [ (int)EPokerCardType.S4 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number4 ),
            [ (int)EPokerCardType.S5 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number5 ),
            [ (int)EPokerCardType.S6 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number6 ),
            [ (int)EPokerCardType.S7 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number7 ),
            [ (int)EPokerCardType.S8 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number8 ),
            [ (int)EPokerCardType.S9 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number9 ),
            [ (int)EPokerCardType.S10 ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Number10 ),
            [ (int)EPokerCardType.SJ  ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Jack ),
            [ (int)EPokerCardType.SQ  ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Queen ),
            [ (int)EPokerCardType.SK  ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.King ),
            [ (int)EPokerCardType.SA  ] = new CardInfo( (int)EPokerSuit.Spades, (int)EPokerRank.Ace ),

            // Special
        };

        public static CardInfo GetCardInfo( int iCardType )
        {
            CardInfo cardInfo;
            CardInfoDic.TryGetValue( iCardType, out cardInfo );

            return cardInfo;
        }
    }

    // 卡片
    public class Card
    {
        public int PokerCardType { get; private set; }
        public CardInfo CardInfo => CardDataHolder.GetCardInfo( PokerCardType );

        /*private float mWeight;
        public float Weight
        {
            get => mWeight;
            set
            {
                if( value < 0f )
                    return;

            }
        }*/

        public Card( int iPokerCardType )
        {
            PokerCardType = iPokerCardType;
        }
    }
}