﻿using BlogSite.Domain.Entities;
using LoremNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Models
{
    public class ArticleModel
    {
        
        public ArticleEntity Article { get; set; }
        // TODO: Сделать запрос в БД, чтобы получить статью по id.
        public ArticleModel(int id)
        {
           Article  = new ArticleEntity(id, "Название " + id.ToString(), "Большое описание на несколько строк", @"C:\Users\Rico\Desktop\Уч. материалы\RedFoxDev\img\_TwB97Q_OSo.jpg", "Lorem.Paragraphs(120, 2, 2).ToString()", "Key, Word, То что надо");
        }
        
        public ArticleEntity Init(object id)
        {

            return Article;
        }

    }

        // TODO: Сделать запрос в БД, чтобы получить статью по id.

}