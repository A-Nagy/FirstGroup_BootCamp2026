import 'package:firstgroup_mobileapp/AllWidgets/MyTextField.dart';
import 'package:flutter/material.dart';

class Examplepage4 extends StatefulWidget {
  const Examplepage4({super.key});

  @override
  State<Examplepage4> createState() => _Examplepage4State();
}

class _Examplepage4State extends State<Examplepage4> {
  String? _selectedValue ;
  bool _isChecked = false ;
  bool _isSwitch = true ;
  
  void _showDialog(BuildContext contect , String title)
  {
    showDialog(
        context: context,
        builder: (context){
          return AlertDialog(
            title: Row(
              children: [
                const Icon(Icons.warning, color: Colors.red),
                const SizedBox(width: 5),
                Text(title)
              ],
            ),
            content: Text('This Is Alert Dialog!!!'),
            actions: [
              TextButton(onPressed: ()=>Navigator.of(context).pop(), child:Text('Ok')),
              TextButton(onPressed: ()=>Navigator.of(context).pop(), child:Text('Cancel'))

            ],
          );
        });
  }
  
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: Text('Form Example'),
        centerTitle: true,
      ),
      body:Form(
          child: Padding(
            padding:EdgeInsets.all(15) ,
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
              /*  TextFormField(
                  decoration: InputDecoration(
                    labelText: "User Name"
                  ),
                  validator: (value)
                  {
                    if(value==null || value.isEmpty)
                    {
                      return "Please Enter Your User Name" ;
                    }
                    return null ;
                  },
                )*/
                Mytextfield(label: 'User Name'),
                SizedBox(height: 20),
                TextFormField(
                  decoration: InputDecoration(
                    labelText: "Password"
                  ),
                  validator: (value)
                  {
                    if(value== null || value.isEmpty)
                    {
                      return "Pls Enter Password" ;
                    }
                    return null ;
                  },
                ),
                Center(
                  child: DropdownButton<String>(
                      items: <String>['Op1','Op2','Op3'].map<DropdownMenuItem<String>>((String value)
                      {
                        return DropdownMenuItem(
                            value: value,
                            child: Text(value));
                      }).toList(),
                      onChanged: (String? value)
                      {
                        setState(() {
                          _selectedValue = value ;
                        });
                      },
                      value: _selectedValue,
                )
                ),
                Checkbox(
                    value: _isChecked,
                    onChanged: (value)
                    {
                      setState(() {
                        _isChecked=value! ;
                      });
                    }),
                Switch(
                    value: _isSwitch,
                    onChanged: (value){
                      setState(() {
                        _isSwitch =value ;
                        print(_isSwitch);
                      });
                    }),
                ElevatedButton(onPressed: ()=>_showDialog(context,'Alert'), child: Text('Dialog'))
              ],
            ),
          )) ,
    );
  }
}
