﻿// <auto-generated />
using Backend_FarmerProjectAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend_FarmerProjectAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220121152326_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Admin", b =>
                {
                    b.Property<string>("email_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("email_ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Bidder_Table", b =>
                {
                    b.Property<int>("Bid_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("aadhar_no")
                        .HasColumnType("bigint");

                    b.Property<long>("account_no")
                        .HasColumnType("bigint");

                    b.Property<string>("add_Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("add_line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("confirm_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("contact_no")
                        .HasColumnType("bigint");

                    b.Property<string>("email_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ifsc_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pan_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pincode")
                        .HasColumnType("int");

                    b.HasKey("Bid_ID");

                    b.ToTable("Bidder_Tables");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Farmer_Table", b =>
                {
                    b.Property<int>("Farmer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("aadhar_no")
                        .HasColumnType("bigint");

                    b.Property<long>("account_no")
                        .HasColumnType("bigint");

                    b.Property<string>("add_Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("add_line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("confirm_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("contact_no")
                        .HasColumnType("bigint");

                    b.Property<string>("email_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ifsc_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pan_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pincode")
                        .HasColumnType("int");

                    b.HasKey("Farmer_ID");

                    b.ToTable("Farmer_Tables");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Insurance", b =>
                {
                    b.Property<int>("I_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Insurance_Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("area")
                        .HasColumnType("int");

                    b.Property<string>("crop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("premium_Amount")
                        .HasColumnType("int");

                    b.Property<string>("season")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("share_Premium")
                        .HasColumnType("int");

                    b.Property<int>("sum_Insured")
                        .HasColumnType("int");

                    b.Property<int>("total_sum")
                        .HasColumnType("int");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("I_Id");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Market_Place", b =>
                {
                    b.Property<string>("crop_Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Previous_Bid")
                        .HasColumnType("int");

                    b.Property<int>("base_Price")
                        .HasColumnType("int");

                    b.Property<string>("crop_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("curr_Bid")
                        .HasColumnType("int");

                    b.HasKey("crop_Type");

                    b.ToTable("Market_Places");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Sell_Request", b =>
                {
                    b.Property<int>("s_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("crop_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("crop_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fertilizer_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("soil_ph")
                        .HasColumnType("int");

                    b.HasKey("s_ID");

                    b.ToTable("sell_Requests");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Sold_History", b =>
                {
                    b.Property<string>("crop_Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MSP")
                        .HasColumnType("int");

                    b.Property<string>("crop_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sold_Price")
                        .HasColumnType("int");

                    b.Property<int>("total_Price")
                        .HasColumnType("int");

                    b.HasKey("crop_Type");

                    b.ToTable("Sold_Histories");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.Welcome_Bidder", b =>
                {
                    b.Property<string>("crop_Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("base_Price")
                        .HasColumnType("int");

                    b.Property<int>("bid_Amount")
                        .HasColumnType("int");

                    b.Property<string>("crop_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("curr_Bid")
                        .HasColumnType("int");

                    b.HasKey("crop_Type");

                    b.ToTable("Welcome_Bidders");
                });

            modelBuilder.Entity("Backend_FarmerProjectAPI.Model.claim_Form", b =>
                {
                    b.Property<string>("Insurance_Company")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cause_Of_Loss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Of_Insuree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Policy_No")
                        .HasColumnType("int");

                    b.Property<int>("Sum_Insured")
                        .HasColumnType("int");

                    b.HasKey("Insurance_Company");

                    b.ToTable("claim_Forms");
                });
#pragma warning restore 612, 618
        }
    }
}
