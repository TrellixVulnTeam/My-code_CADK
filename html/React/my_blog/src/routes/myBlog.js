import express from 'express';
import blogController from '../app/controllers/myBlog.js';

const routerBlog = express.Router();

routerBlog.use('/:slug', blogController.showBlog);

export default routerBlog;
