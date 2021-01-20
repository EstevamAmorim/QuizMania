﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizMania.WebAPI.Data;

namespace QuizMania.WebAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AnswerQuestionAnswer", b =>
                {
                    b.Property<long>("ChosenAnswersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionAnswersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChosenAnswersId", "QuestionAnswersId");

                    b.HasIndex("QuestionAnswersId");

                    b.ToTable("AnswerQuestionAnswer");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("INTEGER");

                    b.Property<long>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Character", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Gold")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HealthPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalXP")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.EffectBase", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemInfoName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemInfoName");

                    b.ToTable("Effects");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.GoldExpense", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExpenseRequested")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RemainingGold")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ResquestTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Result")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("GoldExpense");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.InventoryItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEquipped")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ItemName");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.ItemInfo", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("QuizId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.QuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("QuizFeedbackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuizFeedbackId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Quiz", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.QuizFeedback", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExperienceGained")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoldGained")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelGained")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PercentageOfCorrectChosenAnswers")
                        .HasColumnType("REAL");

                    b.Property<long?>("QuizId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("QuizId");

                    b.ToTable("QuizFeedbacks");
                });

            modelBuilder.Entity("AnswerQuestionAnswer", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Answer", null)
                        .WithMany()
                        .HasForeignKey("ChosenAnswersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMania.WebAPI.Models.QuestionAnswer", null)
                        .WithMany()
                        .HasForeignKey("QuestionAnswersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Answer", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.EffectBase", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.ItemInfo", null)
                        .WithMany("Effects")
                        .HasForeignKey("ItemInfoName");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.GoldExpense", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Character", null)
                        .WithMany("GoldExpenses")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.InventoryItem", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Character", "Character")
                        .WithMany("Items")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMania.WebAPI.Models.ItemInfo", "Item")
                        .WithMany()
                        .HasForeignKey("ItemName");

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Question", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.QuestionAnswer", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");

                    b.HasOne("QuizMania.WebAPI.Models.QuizFeedback", "QuizFeedback")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("QuizFeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("QuizFeedback");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Quiz", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Character", "Owner")
                        .WithMany("Quizzes")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.QuizFeedback", b =>
                {
                    b.HasOne("QuizMania.WebAPI.Models.Character", "Character")
                        .WithMany("QuizFeedbacks")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMania.WebAPI.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");

                    b.Navigation("Character");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Character", b =>
                {
                    b.Navigation("GoldExpenses");

                    b.Navigation("Items");

                    b.Navigation("QuizFeedbacks");

                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.ItemInfo", b =>
                {
                    b.Navigation("Effects");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.Quiz", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("QuizMania.WebAPI.Models.QuizFeedback", b =>
                {
                    b.Navigation("QuestionAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
