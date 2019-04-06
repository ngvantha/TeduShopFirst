using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Model;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper.CreateMap<Post, PostViewModel>();
            Mapper.Initialize(cfg => { cfg.CreateMap<Post, PostViewModel>();});
            Mapper.Initialize(cfg => { cfg.CreateMap<PostCategory, PostCategoryViewModel>(); });
            Mapper.Initialize(cfg => { cfg.CreateMap<PostTag, PostTagViewModel>(); });
            Mapper.Initialize(cfg => { cfg.CreateMap<Tag, TagViewModel>(); });

        }
    }
}