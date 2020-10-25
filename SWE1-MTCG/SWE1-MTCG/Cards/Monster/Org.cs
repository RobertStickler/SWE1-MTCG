﻿using System;
using System.Collections.Generic;
using System.Text;
using Cards;
using Enum;

namespace SWE1_MTCG.Cards.Monster
{
    public class Org : BaseCards
    {
        public Org(int damage, string name, elementTypes element) : base(damage, name, element)
        {
            this.card_type = cardTypes.Monster;
            this.card_property = cardProperty.Org;
        }
    }
}
