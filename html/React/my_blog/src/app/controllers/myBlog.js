import MyBlog from '../models/Course.js';

class blogController {
  showBlog(req, res, next) {
    MyBlog.findOne({ slug: req.params.slug })
      .then(myBlog => {
        res.json(myBlog);
      })
      .catch(next)
  }
}

export default new blogController;