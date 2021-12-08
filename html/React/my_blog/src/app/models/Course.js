import mongoose from "mongoose"
const Schema = mongoose.Schema;

const Course = new Schema({
  name: String,
  description: String,
  image: {type: String},
  createdAt: { type: Date, default: Date.now },
  updatedAt: { type: Date, default: Date.now },
})

export default mongoose.model('course', Course );
