namespace WindowsFormsApplication1
{
    partial class Panel_de_Control
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_comprarPasaje = new System.Windows.Forms.Button();
            this.bt_cancelarPasaje = new System.Windows.Forms.Button();
            this.bt_abmRol = new System.Windows.Forms.Button();
            this.bt_abmMicros = new System.Windows.Forms.Button();
            this.bt_consultaPuntos = new System.Windows.Forms.Button();
            this.bt_abmCiudades = new System.Windows.Forms.Button();
            this.bt_generarViaje = new System.Windows.Forms.Button();
            this.bt_registrarLlegadaMicro = new System.Windows.Forms.Button();
            this.bt_canjearPuntos = new System.Windows.Forms.Button();
            this.bt_listadoEstadistico = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Panel de Control";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "ALFAMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_comprarPasaje
            // 
            this.bt_comprarPasaje.Location = new System.Drawing.Point(23, 153);
            this.bt_comprarPasaje.Name = "bt_comprarPasaje";
            this.bt_comprarPasaje.Size = new System.Drawing.Size(121, 37);
            this.bt_comprarPasaje.TabIndex = 19;
            this.bt_comprarPasaje.Text = "Comprar Pasaje";
            this.bt_comprarPasaje.UseVisualStyleBackColor = true;
            this.bt_comprarPasaje.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelarPasaje
            // 
            this.bt_cancelarPasaje.Location = new System.Drawing.Point(180, 153);
            this.bt_cancelarPasaje.Name = "bt_cancelarPasaje";
            this.bt_cancelarPasaje.Size = new System.Drawing.Size(121, 37);
            this.bt_cancelarPasaje.TabIndex = 22;
            this.bt_cancelarPasaje.Text = "Cancelar Pasaje";
            this.bt_cancelarPasaje.UseVisualStyleBackColor = true;
            // 
            // bt_abmRol
            // 
            this.bt_abmRol.Location = new System.Drawing.Point(23, 248);
            this.bt_abmRol.Name = "bt_abmRol";
            this.bt_abmRol.Size = new System.Drawing.Size(121, 37);
            this.bt_abmRol.TabIndex = 23;
            this.bt_abmRol.Text = "ABM Rol";
            this.bt_abmRol.UseVisualStyleBackColor = true;
            this.bt_abmRol.Click += new System.EventHandler(this.bt_abmRol_Click);
            // 
            // bt_abmMicros
            // 
            this.bt_abmMicros.Location = new System.Drawing.Point(180, 248);
            this.bt_abmMicros.Name = "bt_abmMicros";
            this.bt_abmMicros.Size = new System.Drawing.Size(121, 37);
            this.bt_abmMicros.TabIndex = 24;
            this.bt_abmMicros.Text = "ABM Micros";
            this.bt_abmMicros.UseVisualStyleBackColor = true;
            // 
            // bt_consultaPuntos
            // 
            this.bt_consultaPuntos.Location = new System.Drawing.Point(329, 153);
            this.bt_consultaPuntos.Name = "bt_consultaPuntos";
            this.bt_consultaPuntos.Size = new System.Drawing.Size(121, 37);
            this.bt_consultaPuntos.TabIndex = 26;
            this.bt_consultaPuntos.Text = "Consulta Puntos";
            this.bt_consultaPuntos.UseVisualStyleBackColor = true;
            // 
            // bt_abmCiudades
            // 
            this.bt_abmCiudades.Location = new System.Drawing.Point(329, 248);
            this.bt_abmCiudades.Name = "bt_abmCiudades";
            this.bt_abmCiudades.Size = new System.Drawing.Size(121, 37);
            this.bt_abmCiudades.TabIndex = 25;
            this.bt_abmCiudades.Text = "ABM Ciudades";
            this.bt_abmCiudades.UseVisualStyleBackColor = true;
            // 
            // bt_generarViaje
            // 
            this.bt_generarViaje.Location = new System.Drawing.Point(180, 302);
            this.bt_generarViaje.Name = "bt_generarViaje";
            this.bt_generarViaje.Size = new System.Drawing.Size(121, 37);
            this.bt_generarViaje.TabIndex = 29;
            this.bt_generarViaje.Text = "Generar Viaje";
            this.bt_generarViaje.UseVisualStyleBackColor = true;
            // 
            // bt_registrarLlegadaMicro
            // 
            this.bt_registrarLlegadaMicro.Location = new System.Drawing.Point(25, 302);
            this.bt_registrarLlegadaMicro.Name = "bt_registrarLlegadaMicro";
            this.bt_registrarLlegadaMicro.Size = new System.Drawing.Size(121, 37);
            this.bt_registrarLlegadaMicro.TabIndex = 28;
            this.bt_registrarLlegadaMicro.Text = "Registrar Llegada Micro";
            this.bt_registrarLlegadaMicro.UseVisualStyleBackColor = true;
            // 
            // bt_canjearPuntos
            // 
            this.bt_canjearPuntos.Location = new System.Drawing.Point(180, 198);
            this.bt_canjearPuntos.Name = "bt_canjearPuntos";
            this.bt_canjearPuntos.Size = new System.Drawing.Size(121, 37);
            this.bt_canjearPuntos.TabIndex = 27;
            this.bt_canjearPuntos.Text = "Canjear Puntos";
            this.bt_canjearPuntos.UseVisualStyleBackColor = true;
            // 
            // bt_listadoEstadistico
            // 
            this.bt_listadoEstadistico.Location = new System.Drawing.Point(329, 302);
            this.bt_listadoEstadistico.Name = "bt_listadoEstadistico";
            this.bt_listadoEstadistico.Size = new System.Drawing.Size(121, 37);
            this.bt_listadoEstadistico.TabIndex = 30;
            this.bt_listadoEstadistico.Text = "Listado Estadistico";
            this.bt_listadoEstadistico.UseVisualStyleBackColor = true;
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(375, 371);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 23);
            this.bt_salir.TabIndex = 31;
            this.bt_salir.Text = "&Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            // 
            // Panel_de_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 406);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_listadoEstadistico);
            this.Controls.Add(this.bt_generarViaje);
            this.Controls.Add(this.bt_registrarLlegadaMicro);
            this.Controls.Add(this.bt_canjearPuntos);
            this.Controls.Add(this.bt_consultaPuntos);
            this.Controls.Add(this.bt_abmCiudades);
            this.Controls.Add(this.bt_abmMicros);
            this.Controls.Add(this.bt_abmRol);
            this.Controls.Add(this.bt_cancelarPasaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_comprarPasaje);
            this.Name = "Panel_de_Control";
            this.Text = "Panel de Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_comprarPasaje;
        private System.Windows.Forms.Button bt_cancelarPasaje;
        private System.Windows.Forms.Button bt_abmRol;
        private System.Windows.Forms.Button bt_abmMicros;
        private System.Windows.Forms.Button bt_consultaPuntos;
        private System.Windows.Forms.Button bt_abmCiudades;
        private System.Windows.Forms.Button bt_generarViaje;
        private System.Windows.Forms.Button bt_registrarLlegadaMicro;
        private System.Windows.Forms.Button bt_canjearPuntos;
        private System.Windows.Forms.Button bt_listadoEstadistico;
        private System.Windows.Forms.Button bt_salir;
    }
}