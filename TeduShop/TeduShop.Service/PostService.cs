using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;
using TeduShopData.Infratructure;
using TeduShopData.Repositoris;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChange();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitofWork _unitofWork;
        public PostService(IPostRepository postRepository, IUnitofWork unitofWork)
        {
            this._postRepository = postRepository;
            this._unitofWork = unitofWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
           return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //"&&"&& p.PostTag.Contains(tag) co the them dieu kien vao ham
            return _postRepository.GetMultiPaging(p=>p.Status, out totalRow, page,pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(p => p.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
           _unitofWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
