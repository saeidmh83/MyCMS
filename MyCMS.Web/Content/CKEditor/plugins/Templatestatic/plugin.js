﻿CKEDITOR.plugins.add('Templatestatic',
{
    requires: ['richcombo'], //, 'styles' ],
    init: function (editor) {
        var config = editor.config,
           lang = editor.lang.format;

        // Gets the list of tags from the settings.
        var tags = []; //new Array();
        //this.add('value', 'drop_text', 'drop_label');
        $.ajax({
            type: 'GET',
            url: getCurentControllerUrl('BindSelectDrop'),
            success: function (data) {
                FunctionBinde(data);

               // bindStatical(data);
            }
        });
        
        function FunctionBinde(items) {
            var count=0;
            for (var i in items) {
                tags[count] = [items[count].Value, items[count].Text, items[count].Text];
                count++;
            }

       }


        // Create style objects for all defined styles.

        editor.ui.addRichCombo('Templatestatic',
           {
               label: "ثابت ها",
               title: "Insert Templatestatic",
               className: 'cke_format',
               multiSelect: false,

               panel:
               {
                   
                   css: [config.contentsCss, CKEDITOR.getUrl(CKEDITOR.skin.getPath('editor') + 'editor.css')]
               },

               init: function () {

                   //this.add('value', 'drop_text', 'drop_label');
                   for (var this_tag in tags) {
                       this.add(tags[this_tag][0], tags[this_tag][1], tags[this_tag][2]);
                   }
                   
               },

               onClick: function (value) {
                   editor.focus();
                   editor.fire('saveSnapshot');
                   editor.insertHtml('[##' + value + '##]');
                   editor.fire('saveSnapshot');
               }
           });
    }
});