import 'package:flutter/material.dart';

class Examplepage2 extends StatelessWidget {
  const Examplepage2({super.key});

  @override
  Widget build(BuildContext context) {
    return Directionality(
      textDirection: TextDirection.rtl,
      child: Scaffold(
        appBar: AppBar(
          title:Text('Row & Column Example'),
          backgroundColor: Colors.blue),
        body:SingleChildScrollView(
          child: Column(
           // mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              Text('Row'),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Icon(Icons.person,color: Colors.amber,size: 60,),
                    Icon(Icons.apple,color: Colors.amber,size: 60),
                    Icon(Icons.update,color: Colors.amber,size: 60),
          
          
                  ]
              ),
              const   SizedBox(height: 20),
              Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Icon(Icons.person,color: Colors.amber,size: 60,),
                    Icon(Icons.apple,color: Colors.amber,size: 60),
                    Icon(Icons.update,color: Colors.amber,size: 60),
          
          
                  ]
              ),
              const   SizedBox(height: 20),
              ElevatedButton(
                  onPressed: (){},
                  child: Text('Elevated Button')),
              TextButton(
                  onPressed: (){},
                  child: Text('Text Button')),
              OutlinedButton(
                  onPressed: (){},
                  child: Text('Outlined Button')),
              const   SizedBox(height: 20),
              ElevatedButton(
                  onPressed: (){},
                  child: Icon(Icons.add_box_rounded)),
              TextButton(
                  onPressed: (){},
                  child:Icon(Icons.home)),
              OutlinedButton(
                  onPressed: (){},
                  child:SizedBox(
                    width: 75,
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Text('Add'),
                        Icon(Icons.add)
                      ],
                    ),
                  )),
              const   SizedBox(height: 20),
              FloatingActionButton(
                  onPressed: (){}
              ,child: Text('Press Me'),),
              GestureDetector(
                onTap: (){
                  print('Tapped!');
                },
                onLongPress: (){
                  print('Long Press!');
                },
                onDoubleTap: () {
                  print('Double Tap!');
                },
                child: Text('Gesture Detector'),
              ),
              InkWell(
                onTap: (){
                  print('InkWell tapped!');
                },
                borderRadius: BorderRadius.circular(8),
                child: Container(
                  padding: EdgeInsets.all(16),
                  decoration: BoxDecoration(
                    color: Colors.amber,
                    borderRadius: BorderRadius.circular(8),
                  ),
                  child: Text( 'InkWell (with ripple)',style: TextStyle(color: Colors.black,),),
                ),
              ),
              InkResponse(
                onTap: (){
                  print('InkResponse tapped!');
                },
                radius: 30,
                child: Icon(Icons.favorite,size: 40,color: Colors.red,),
              ),
              GestureDetector(
                onTap: () {
                  print('Image tapped');
                },
                child: Image.network(
                  'https://picsum.photos/200',
                  width: 120,
                  height: 120,
                ),
              ),
              Container(
                decoration: BoxDecoration(
                    border: Border.all(
                      color: Colors.blue,
                      style: BorderStyle.solid,
                      width: 2,
                    ),
                    borderRadius: BorderRadius.circular(20)),
                child: ListTile(
                  leading: Icon(Icons.person),
                  title: Text('Profile') ,
                  subtitle:Text('Go to profile page') ,
                  trailing: const Icon(Icons.arrow_forward_ios),
                  onTap: (){
                    print('ListTile tapped!');
                  },
                ),
              )
             ],
           ),
        ) ,
        floatingActionButton:FloatingActionButton(
      onPressed: (){}
      ,child: Text('Press Me')) ,
      ),
    );
  }
}
