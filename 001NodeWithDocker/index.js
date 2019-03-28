const express=require('express');
const app=express();


app.get('/',function(req,res){
    res.send("Request succesfull!");
});

const port=7000|| process.env.port;

app.listen(port,function(){
    console.log("server listening at port :"+port);
});