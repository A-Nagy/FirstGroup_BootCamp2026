import 'package:flutter/material.dart';

class Mytextfield extends StatelessWidget {

  String label ;
  Mytextfield({super.key, required this.label});

  @override
  Widget build(BuildContext context) {
    return TextFormField(      
      decoration: InputDecoration(
        labelText: label,
        enabledBorder: OutlineInputBorder(
          borderRadius: BorderRadius.all(Radius.circular(20)),
          borderSide: BorderSide(
            color: Colors.red,
            width: 1
          )
        )
      ),
      validator: (value)
      {
        if(value==null || value.isEmpty)
        {
          return "Please Enter Your ${label}" ;
        }
        return null ;
      },
    );
  }
}
