export const  multipleMongooseToObject =  function (mongooses) {
    return mongooses.map(mongoose => mongoose.toObject())
  };
export const mongooseToObject = function (mongoose) {
    return mongoose ? mongoose.toObject() : mongoose;
  }
