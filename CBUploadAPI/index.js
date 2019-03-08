const express = require('express');
const bodyParser = require('body-parser');
const multiparty = require('connect-multiparty'),
  multipartyMiddleware = multiparty();
const fs = require('fs');
const s3fs = require('s3fs');
const app = express();

//configure s3fs
const s3fsImplementation = new s3fs('nurenbucket', {
  accessKeyId: '',
  secretAccessKey: ''
})

//configure app
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static('public'));
app.use(multipartyMiddleware);

//API Routes
app.get('/', (req, res) => {
	res.sendFile(__dirname + 'public/index.html');
});

app.post('/test', (req, res) => {
  var file = req.files.file;
  var stream = fs.createReadStream(file.path);
  return s3fsImplementation.writeFile(file.originalFileName, stream).then(function(){
    fs.unlink(file.path, function(err){
      if(err){
        console.error(err);
      }
    });
    res.send('Uploaded!!');
  });
});

app.listen(process.env.PORT || 5001, () => console.log('server started'));
